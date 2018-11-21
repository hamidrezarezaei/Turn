using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nobatgir.Data;
using Nobatgir.Model;

namespace Nobatgir.Services
{
    public class Repository
    {
        #region constructor
        private readonly MyContext _myContext;

        private readonly int allSiteId = 1;
        private int pageSize = 2;

        public Repository(MyContext myContext)
        {
            this._myContext = myContext;
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
        public BaseClass AddRow(BaseClass row)
        {
            this.Labeling(row);
            this._myContext.Add(row);
            this._myContext.SaveChanges();
            return row;
        }

        #endregion

        //  #region EntityType
        //public PagedResult<EntityType> GetEntityTypes(int pageNumber, string searchString = "")
        //{
        //    if (pageNumber == 0)
        //        pageNumber = 1;

        //    IQueryable<EntityType> query;
        //    if (!String.IsNullOrEmpty(searchString))
        //        query = myContext.EntityTypes.Where(t => t.Title.Contains(searchString) &&
        //                                     !t.IsDeleted);
        //    else
        //        query = myContext.EntityTypes.Where(t => !t.IsDeleted);

        //    PagedResult<EntityType> result = new PagedResult<EntityType>();
        //    result.PagingData.CurrentPage = pageNumber;
        //    result.PagingData.ItemsPerPage = pageSize;
        //    result.PagingData.TotalItems = query.Count();
        //    result.Items = query.OrderBy(p => p.OrderIndex).
        //        Skip((pageNumber - 1) * pageSize).Take(pageSize).
        //        ToList();
        //    return result;
        //}

        //public EntityType GetEntityType(int? id)
        //{
        //    if (id == null)
        //        return null;
        //    var entityType = myContext.EntityTypes.SingleOrDefault(et => et.Id == id && !et.IsDeleted);
        //    return entityType;
        //}



        // #endregion

        // #region Entity
        public List<Site> GetSites()
        {
            return _myContext.Sites.Where(e => !e.IsDeleted).ToList();
        }

        public PagedResult<Site> GetSites(int pageNumber, string searchString = "")
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IQueryable<Site> query;

            if (!string.IsNullOrEmpty(searchString))
                query = _myContext.Sites.Where(e => e.Title.Contains(searchString) && !e.IsDeleted);
            else
                query = _myContext.Sites.Where(e => !e.IsDeleted);

            var result = new PagedResult<Site>
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

        public PagedResult<Expert> GetExperts(int pageNumber, string searchString = "")
        {
            if (pageNumber == 0)
                pageNumber = 1;

            IQueryable<Expert> query;

            if (!string.IsNullOrEmpty(searchString))
                query = _myContext.Experts.Where(e => e.Title.Contains(searchString) && !e.IsDeleted);
            else
                query = _myContext.Experts.Where(e => !e.IsDeleted);

            var result = new PagedResult<Expert>
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

        //public IEnumerable<AdminMenu> GetAdminMenus()
        //{
        //    var adminMenus = _myContext.AdminMenus.Where(am => am.IsActive && !am.IsDeleted).
        //                                        OrderBy(am => am.OrderIndex);
        //    return adminMenus;
        //}
    }

}
