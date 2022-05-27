using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace EpzNotDead.Shared.Services
{
    public interface IPostService
    {
        Task<List<AdditionalContent>> GetAdditionalContent(Guid id);
        Task<List<Link>> GetLinks(Guid id);
        Task<Post?> GetPost(Expression<Func<Post, bool>> filter);
        Task<List<Post>> GetPosts(Expression<Func<Post, bool>> filter);
        Task ScoreUp(Guid id);
    }

    public class PostService : IPostService
    {
        private IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Post>> GetPosts(Expression<Func<Post, bool>> filter)
        {
            return (await _unitOfWork.Repository<Post>().GetMany(filter))
                .ToList();
        }

        public async Task<Post?> GetPost(Expression<Func<Post, bool>> filter)
        {
            return await (await _unitOfWork.Repository<Post>().GetMany(filter))
                .Include(p => p.Links).Include(p => p.AdditionalContent).FirstOrDefaultAsync();
        }

        public async Task<List<AdditionalContent>> GetAdditionalContent(Guid id)
        {
            var result = await _unitOfWork.Repository<AdditionalContent>().GetMany(c => c.PostId.Equals(id));
            return result.ToList();
        }

        public async Task<List<Link>> GetLinks(Guid id)
        {
            var result = await _unitOfWork.Repository<Link>().GetMany(c => c.PostId.Equals(id));
            return result.ToList();
        }

        public async Task ScoreUp(Guid id)
        {
            var scoring = await _unitOfWork.Repository<Post>().GetById(id);
            scoring.Score += 1;
            _ = await _unitOfWork.SaveChangesAsync();
        }
    }
}
