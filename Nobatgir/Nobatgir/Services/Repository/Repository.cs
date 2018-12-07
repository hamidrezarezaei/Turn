using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.Util;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        #region constructor
        private readonly MyContext _myContext;

        private int? SiteId;
        private int pageSize = 2;
        IHttpContextAccessor httpContextAccessor;

        public Repository(MyContext myContext,
            IHttpContextAccessor httpContextAccessor)
        {
            this._myContext = myContext;

            this.httpContextAccessor = httpContextAccessor;

            this.SetSiteID();
        }

        private void SetSiteID()
        {
            var host = this.httpContextAccessor.HttpContext.Request.Host.ToString().ToLower();

            if (host.Contains("localhost"))
                this.SiteId = 1;
            else
                this.SiteId = this._myContext.Sites.FirstOrDefault(x => x.Domain.ToLower() == host)?.ID;
        }

        #endregion

        #region common
        private void Authorize(BaseClass row)
        {
            //if (row.siteId != 0 && row.siteId != this.siteId)
            //    throw new Exception("شما مجوز تغییر این قسمت را ندارید.");
        }

        private void Labeling(BaseClass row)
        {
            //row.siteId = this.siteId;
            //row.updateUserId = this.userId;
            row.UpdateDateTime = DateTime.Now;
        }

        public BaseClass GetRow(int? id, Type type)
        {
            if (id == null)
                return null;

            BaseClass row = _myContext.Find(type, id) as BaseClass;
            this.Authorize(row);
            return row;
        }

        public BaseClass UpdateRow(BaseClass row)
        {
            this.Authorize(row);
            this.Labeling(row);
            this._myContext.Update(row);
            this._myContext.SaveChanges();
            return row;
        }
        public void DeleteRow(BaseClass row)
        {
            this.Authorize(row);
            this.Labeling(row);
            row.IsDeleted = true;
            this._myContext.Update(row);
            this._myContext.SaveChanges();
        }
        public BaseClass AddRow<T>(T row) where T : BaseClass
        {
            var indx = this._myContext.Set<T>().Any() ? this._myContext.Set<T>().Max(x => x.OrderIndex) : 1;
            row.OrderIndex = indx + 1;

            this.Labeling(row);
            this._myContext.Add(row);

            this._myContext.SaveChanges();
            return row;
        }

        #endregion


        public string Translate(Nobatgir.Model.Terms term)
        {
            var sd = this._myContext.SiteDictionaries.FirstOrDefault(x =>
                x.SiteID == this.SiteId && x.DictionaryTermID == (int)term);

            if (sd != null)
                return sd.Value;

            var sitekindid = this._myContext.Sites.Where(x => x.ID == this.SiteId).Select(x => x.SiteKindID).First();

            var f = this._myContext.SiteKindDictionaries.FirstOrDefault(x => x.SiteKindID == sitekindid
                                                                             && x.DictionaryTermID == (int)term);
            return f.Value;
        }


        public IQueryable<T> FilterExist<T>(IQueryable<T> db) where T : BaseClass
        {
            return db.Where(am => !am.IsDeleted).OrderBy(am => am.OrderIndex);
        }

        public IEnumerable<T> FilterExistEnum<T>(IEnumerable<T> db) where T : BaseClass
        {
            return db.Where(am => !am.IsDeleted);//.OrderBy(am => am.OrderIndex);
        }

        public IQueryable<T> FilterActive<T>(IQueryable<T> db) where T : BaseClass
        {
            return db.Where(am => am.IsActive);
        }

        public PagedResult<T> GetPagedResult<T>(IQueryable<T> db, int pageNumber, string searchString = "") where T : BaseClass
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IEnumerable<T> query;

            if (!string.IsNullOrEmpty(searchString))
                query = FilterExist(db).Where(e => e.Title.Contains(searchString));
            else
                query = FilterExist(db);

            var result = new PagedResult<T>
            {
                PagingData =
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = pageSize,
                    TotalItems = query.Count()
                },
                Items = query.OrderBy(e => e.OrderIndex).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            return result;
        }


        public IQueryable<T> GetList<T>(Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = FilterExist(_myContext.Set<T>());

            if (exp != null)
                q = FilterExist(_myContext.Set<T>()).Include(exp);

            return q;
        }

        public PagedResult<T> GetListWithPaging<T>(int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetList(exp);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public T GetSingle<T>(int ID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetList(exp);

            return q.FirstOrDefault(x => x.ID == ID);
        }

        public IQueryable<T> GetListActive<T>(Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = FilterActive(GetList(exp));

            return q;
        }

        public PagedResult<T> GetListActiveWithPaging<T>(int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetListActive(exp);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public IQueryable<T> GetListByParent<T>(Expression<Func<T, int>> ParentColumn, int ParentID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var expression = (MemberExpression)ParentColumn.Body;
            string name = expression.Member.Name;

            var q = GetList(exp).Where(x => (int)x.GetValue(name) == ParentID);

            return q;
        }

        public PagedResult<T> GetListByParentWithPaging<T>(Expression<Func<T, int>> ParentColumn, int ParentID, int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetListByParent(ParentColumn, ParentID, exp);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public IQueryable<T> GetListActiveByParent<T>(Expression<Func<T, int>> ParentColumn, int ParentID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var expression = (MemberExpression)ParentColumn.Body;
            string name = expression.Member.Name;

            var q = GetListActive(exp).Where(x => (int)x.GetValue(name) == ParentID);

            return q;
        }

        public PagedResult<T> GetListActiveByParentWithPaging<T>(Expression<Func<T, int>> ParentColumn, int ParentID, int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetListActiveByParent(ParentColumn, ParentID, exp);

            return GetPagedResult(q, pageNumber, searchString);
        }

    }
}
