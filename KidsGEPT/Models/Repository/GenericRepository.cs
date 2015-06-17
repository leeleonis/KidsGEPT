using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using KidsGEPT.Areas.backend.Models;
using System.Data.Entity.Infrastructure;

namespace KidsGEPT.Models.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal KidsGEPTEntities context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(KidsGEPTEntities context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        /// <summary>
        /// 下拉選單項目
        /// </summary>
        /// <param name="filter">過濾條件</param>
        /// <param name="toselect"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<SelectListModelcs> ToSelectitem(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, SelectListModelcs>> toselect = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return query.Select(toselect).Distinct().ToList();
        }
    }
}