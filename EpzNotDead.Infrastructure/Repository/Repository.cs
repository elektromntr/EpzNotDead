 using EpzNotDead.Infrastructure.Configuration;
using EpzNotDead.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EpzNotDead.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EpzNotDeadContext _db;
        private readonly DbSet<T> _dbSet;

        public Repository(EpzNotDeadContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public virtual IQueryable<T> Get() => _dbSet;

        public virtual async Task<T?> GetById(object id) => await _dbSet.FindAsync(id);

        public virtual async Task<T> Add(T entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task AddRange(IEnumerable<T> entities) => await _dbSet.AddRangeAsync(entities);

        public virtual async Task Delete(object id)
        {
            var entityToDelete = _dbSet.FindAsync(id);
            Delete(await entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (_db.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }

            _dbSet.Remove(entityToDelete);
        }

        public virtual void DeleteRange(IEnumerable<T> entitiesToDelete) => _dbSet.RemoveRange(entitiesToDelete);

        public virtual void Update(T entityToUpdate)
        {
            if (_db.Entry(entityToUpdate).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToUpdate);
            }

            _db.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void SaveChangesSync() => _db.SaveChanges();

        public virtual async Task SaveChangesAsync() => await _db.SaveChangesAsync();

        public async Task<T?> GetOne(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }

        public async Task<IQueryable<T>> GetMany(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public IQueryable<T> GetOneSync(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter);
        }
}

}
