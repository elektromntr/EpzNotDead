using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EpzNotDead.Shared.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts(Expression<Func<Post, bool>> filter);
    }

    public class PostService : IPostService
    {
        private IRepository<Post> _repository;

        public PostService(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public async Task<List<Post>> GetPosts(Expression<Func<Post, bool>> filter)
        {
            return (await _repository.GetMany(filter)).ToList();
        }
    }
}
