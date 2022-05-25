using EpzNotDead.Infrastructure.Configuration;
using EpzNotDead.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EpzNotDead.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EpzNotDeadContext Context;
        private readonly DbSet<T> DbSet;

        public Repository(EpzNotDeadContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public virtual IQueryable<T> Get() => DbSet;

        public virtual async Task<T> GetById(object id) => await DbSet.FindAsync(id);

        public virtual async Task<T> Add(T entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            await DbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task AddRange(IEnumerable<T> entities) => await DbSet.AddRangeAsync(entities);

        public virtual async Task Delete(object id)
        {
            var entityToDelete = DbSet.FindAsync(id);
            Delete(await entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }

            DbSet.Remove(entityToDelete);
        }

        public virtual void DeleteRange(IEnumerable<T> entitiesToDelete) => DbSet.RemoveRange(entitiesToDelete);

        public virtual void Update(T entityToUpdate)
        {
            if (Context.Entry(entityToUpdate).State == EntityState.Detached)
            {
                DbSet.Attach(entityToUpdate);
            }

            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void SaveChanges() => Context.SaveChanges();

        public virtual async Task SaveChangesAsync() => await Context.SaveChangesAsync();

        public async Task<T?> GetOne(Expression<Func<T, bool>> filter)
        {
            return await DbSet.FirstOrDefaultAsync(filter);
        }

        public Task<IQueryable<T>> GetMany(Expression<Func<T, bool>> filter)
        {
            return Task.FromResult(DbSet.Where(filter));
        }
    }

}
