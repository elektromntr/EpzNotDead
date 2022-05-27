using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EpzNotDead.Infrastructure.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetOne(Expression<Func<TEntity, bool>> filter);
        Task<IQueryable<TEntity>> GetMany(Expression<Func<TEntity, bool>> filter);
		IQueryable<TEntity> Get();
		Task<TEntity> GetById(object id);
		Task<TEntity> Add(TEntity entity);
		Task Delete(object id);
		void Delete(TEntity entityToDelete);
		void Update(TEntity entityToUpdate);
		void SaveChangesSync();
		Task AddRange(IEnumerable<TEntity> entities);
		void DeleteRange(IEnumerable<TEntity> entitiesToDelete);
		Task SaveChangesAsync();
    }
}
