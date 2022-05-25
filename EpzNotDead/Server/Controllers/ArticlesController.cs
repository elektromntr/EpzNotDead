using Microsoft.AspNetCore.Mvc;
using EpzNotDead.Infrastructure.Configuration;
using EpzNotDead.Infrastructure.Enums;
using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Shared.Services;

namespace EpzNotDead.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private EpzNotDeadContext _db;
        private IPostService _postService;

        public ArticlesController(IPostService postService, 
            EpzNotDeadContext db)
        {
            _db = db;
            _postService = postService;
        }
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetArticles() =>
            await GetArticlesByType(null);

        [HttpGet]
        [Route("{type}")]
        public async Task<ActionResult> GetArticlesByType(string? type)
        {
            List<Post> result = new();
            if (string.IsNullOrWhiteSpace(type))
            {
                //result = _db.Posts.Take(6).ToList();
                result = await _postService
                    .GetPosts(p => p.Archived != true);
            }
            else
            {
                Enum.TryParse<PostType>(type, true, out var typeEnum);
                result = await _postService
                    .GetPosts(p => p.Type.Equals(typeEnum) 
                        && p.Archived != true);
                    
            }

            return Ok(result);
        }

        //[HttpGet]
        //[Route("Music")]
        //public async Task<ActionResult> GetMusic()
        //{
        //    var result = _db.Posts.ToList();

        //    return Ok(result);
        //}

        [HttpPut]
        [Route("ScoreUp/{id:Guid}")]
        public async Task<ActionResult> ScoreUp(Guid id)
        {
            try
            {
                var scoring = _db.Posts.FirstOrDefault(n => n.Id.Equals(id));
                scoring.Score += 1;
                _ = await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception e)
            {
                //logger
                return BadRequest(e.Message);
            }
        }
    }
}
