﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private Navik_DBEntities _db;

        private DbSet<TEntity> _dbSet;

        public GenericRepository(Navik_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            _dbSet.Remove(entity);
        }
    }
}
