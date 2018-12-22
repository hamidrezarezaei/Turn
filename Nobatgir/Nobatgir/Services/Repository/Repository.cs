using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
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
        private readonly UserManager<User> _usermanager;
        private readonly RoleManager<Role> _rolemanager;

        public int SiteID;
        public SiteKinds SiteKindID;

        public int CategoryID;
        public int ExpertID;

        public int UserID => int.Parse(httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

        public int UserLevelID
        {
            get
            {
                var user = _usermanager.GetUserAsync(httpContextAccessor.HttpContext.User).Result;
                return user.Level;
            }
        }

        public int CurrentLevel
        {
            get
            {
                var routedata = this.httpContextAccessor.HttpContext.GetRouteData();

                if (routedata.Values["catname"] != null)
                {
                    if (routedata.Values["expertname"] != null)
                        return 4;

                    return 3;
                }

                if (SiteID == 1)
                    return 1;

                return 2;

                //if (ExpertID != 0)
                //    return 4;

                //if (this.CategoryID != 0)
                //    return 3;

                //if (SiteID == 1)
                //    return 1;

                //return 2;
            }
        }

        public string GetControllerName
        {
            get
            {
                var routedata = this.httpContextAccessor.HttpContext.GetRouteData();
                return routedata.Values["controller"].ToString();
            }
        }

        public string GetActionName
        {
            get
            {
                var routedata = this.httpContextAccessor.HttpContext.GetRouteData();
                return routedata.Values["action"].ToString();
            }
        }

        private int pageSize = 10;

        IHttpContextAccessor httpContextAccessor;

        public Repository(MyContext myContext,
            UserManager<User> usermanager,
            RoleManager<Role> rolemanager,
            IHttpContextAccessor httpContextAccessor)
        {
            this._myContext = myContext;
            _usermanager = usermanager;
            _rolemanager = rolemanager;

            this.httpContextAccessor = httpContextAccessor;

            this.SetSiteParams();

            this.SetLevelParams();
        }

        private void SetLevelParams()
        {
            // اگر برای تک دکتر یا آرایشگر است
            if (this.SiteKindID == SiteKinds.Doctor || this.SiteKindID == SiteKinds.Barber)
            {
                var drcat = this._myContext.Categories.Include(x => x.Experts).FirstOrDefault(x => x.SiteID == this.SiteID);

                if (drcat == null)
                    throw new Exception("نداریم");

                this.CategoryID = drcat.ID;

                var expert = drcat.Experts.FirstOrDefault();

                if (expert == null)
                    throw new Exception("نداریم");

                this.ExpertID = expert.ID;

                return;
            }

            var routedata = this.httpContextAccessor.HttpContext.GetRouteData();

            var catname = routedata.Values["catname"];

            if (catname != null)
                this.CategoryID = this._myContext.Categories.FirstOrDefault(x =>
                                      x.Name.ToLower() == catname.ToString().ToLower() && x.SiteID == this.SiteID)?.ID ?? 0;

            var expertname = routedata.Values["expertname"];

            if (expertname != null)
                this.ExpertID = this._myContext.Experts.FirstOrDefault(x =>
                                    x.Name.ToLower() == expertname.ToString().ToLower() && x.CategoryID == this.CategoryID)?.ID ?? 0;
        }

        private void SetSiteParams()
        {
            var host = this.httpContextAccessor.HttpContext.Request.Host.ToString().ToLower();

            var site = this._myContext.Sites.FirstOrDefault(x => x.Domain.ToLower() == host.Replace("www.", ""));

            var routedata = this.httpContextAccessor.HttpContext.GetRouteData();
            var sitename = routedata.Values["sitename"];

            // اگر خود سایت superadmin باشد
            if (site != null && sitename == null)
            {
                this.SiteID = site.ID;
                this.SiteKindID = site.SiteKindEnum;
                return;
            }

            if (host.Contains("localhost") && sitename == null)
            {
                this.SiteID = 1;
                this.SiteKindID = SiteKinds.SuperAdmin;
                return;
            }

            if (sitename == null)
                throw new Exception(host + " 222این سایت   ندارد.");

            var s = this._myContext.Sites.FirstOrDefault(x => x.Name.ToLower() == sitename.ToString().ToLower());

            if (s != null)
            {
                this.SiteID = s.ID;
                this.SiteKindID = (SiteKinds)s.SiteKindID;
                return;
            }

            throw new Exception(sitename + " 1111این سایت   ندارد.");

            //if (host.Contains("localhost"))
            //{
            //    this.SiteID = 1;
            //    this.SiteKindID = SiteKinds.SuperAdmin;
            //}
            //else
            //{
            //    var site = this._myContext.Sites.FirstOrDefault(x => x.Domain.ToLower() == host);

            //    if (site == null)
            //        throw new Exception(host + " 222این سایت   ندارد.");

            //    this.SiteID = site.ID;
            //    this.SiteKindID = site.SiteKindEnum;
            //}
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
            row.UserID = this.UserID;
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
        public T AddRow<T>(T row) where T : BaseClass
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
            var sd = this._myContext.SiteDictionaries.FirstOrDefault(x => x.SiteID == this.SiteID && x.DictionaryTermID == (int)term);

            if (sd != null)
                return sd.Value;

            var sitekindid = this._myContext.Sites.Where(x => x.ID == this.SiteID).Select(x => x.SiteKindID).First();

            var f = this._myContext.SiteKindDictionaries.FirstOrDefault(x => x.SiteKindID == sitekindid
                                                                             && x.DictionaryTermID == (int)term);
            return f.Value;
        }

        public string GetSetting(Settings setting)
        {
            var expertsetting = this._myContext.ExpertSettings.FirstOrDefault(x => x.ExpertID == this.ExpertID && x.Name == setting.ToString());

            if (expertsetting != null)
                return expertsetting.Value;

            var catsetting = this._myContext.CategorySettings.FirstOrDefault(x => x.CategoryID == this.CategoryID && x.Name == setting.ToString());

            if (catsetting != null)
                return catsetting.Value;

            var sitesetting = this._myContext.SiteSettings.FirstOrDefault(x => x.SiteID == this.SiteID && x.Name == setting.ToString());

            if (sitesetting != null)
                return sitesetting.Value;

            var sd = this._myContext.SiteKindSettings.FirstOrDefault(x => x.SiteKindID == (int)this.SiteKindID && x.Name == setting.ToString());

            return sd?.Value;
        }

        //public string GetSiteKindSetting(Settings setting)
        //{
        //    var sd = this._myContext.SiteKindSettings.FirstOrDefault(x => x.SiteKindID == (int)this.SiteKindID && x.Name == setting.ToString());

        //    return sd?.Value;
        //}

        //public string GetSiteSetting(Settings setting)
        //{
        //    var sd = this._myContext.SiteSettings.FirstOrDefault(x => x.SiteID == this.SiteID && x.Name == setting.ToString());

        //    return sd?.Value;
        //}

        //public string GetExpertSetting(Settings setting)
        //{
        //    var sd = this._myContext.ExpertSettings.FirstOrDefault(x => x.ExpertID == this.ExpertID && x.Name == setting.ToString());

        //    return sd?.Value;
        //}

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


        public IQueryable<T> GetList<T>(Expression<Func<T, object>> includeexp = null) where T : BaseClass
        {
            var q = FilterExist(_myContext.Set<T>());

            if (includeexp != null)
                q = q.Include(includeexp);

            return q;
        }

        public PagedResult<T> GetListWithPaging<T>(int pageNumber, string searchString = "", Expression<Func<T, object>> includeexp = null) where T : BaseClass
        {
            var q = GetList(includeexp);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public T GetSingle<T>(int ID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetList(exp);

            return q.FirstOrDefault(x => x.ID.Equals(ID));
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

        public IQueryable<T> GetListByParent<T, K>(Expression<Func<T, K>> ParentColumn, K ParentID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var expression = (MemberExpression)ParentColumn.Body;
            string name = expression.Member.Name;

            var q = GetList(exp).Where(x => ((K)x.GetValue(name)).Equals(ParentID));

            return q;
        }

        public PagedResult<T> GetListByParentWithPaging<T, K>(Expression<Func<T, K>> ParentColumn, K ParentID, int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetListByParent(ParentColumn, ParentID, exp);

            return GetPagedResult(q, pageNumber, searchString);
        }

        public IQueryable<T> GetListActiveByParent<T, K>(Expression<Func<T, K>> ParentColumn, K ParentID, Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var expression = (MemberExpression)ParentColumn.Body;
            string name = expression.Member.Name;

            var q = GetListActive(exp).Where(x => ((K)x.GetValue(name)).Equals(ParentID));

            return q;
        }

        public PagedResult<T> GetListActiveByParentWithPaging<T, K>(Expression<Func<T, K>> ParentColumn, K ParentID, int pageNumber, string searchString = "", Expression<Func<T, object>> exp = null) where T : BaseClass
        {
            var q = GetListActiveByParent(ParentColumn, ParentID, exp);

            return GetPagedResult(q, pageNumber, searchString);
        }
    }
}
