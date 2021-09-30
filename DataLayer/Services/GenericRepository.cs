using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

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
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            return query.Select(l => l).ToList();
        }
        public virtual IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> where = null)
        {
            _dbSet = _db.Set<TEntity>();
            return _dbSet.Where(where).ToList();
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
        public void Save()
        {
            _db.SaveChangesAsync().Wait();
        }
        public virtual void update(TEntity entity, Expression<Func<TEntity, bool>> where = null)
        {
            var local = _dbSet.Local.FirstOrDefault();
            if (local != null)
            {
                _db.Entry(local).State = EntityState.Detached;
            }
            //_dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
