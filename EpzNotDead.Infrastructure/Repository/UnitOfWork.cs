using EpzNotDead.Infrastructure.Repository.Interfaces;

namespace EpzNotDead.Infrastructure.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private Configuration.EpzNotDeadContext _db;
        public UnitOfWork(Configuration.EpzNotDeadContext db)
        {
            _db = db;
        }
        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)) == true)
                return Repositories[typeof(T)] as IRepository<T>;

            IRepository<T> repo = new Repository<T>(_db);
            Repositories.Add(typeof(T), repo);
            return repo;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _db.SaveChangesAsync();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    _db.Dispose();
            }
            this.disposed = true;
        }
        public void Dispose()
        {
        }
    }
}
