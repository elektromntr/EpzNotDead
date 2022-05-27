using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpzNotDead.Infrastructure.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepository<T> Repository<T>() where T : class;
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
