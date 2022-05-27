using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Infrastructure.Enums;
using EpzNotDead.Shared.Dtos;
using EpzNotDead.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace EpzNotDead.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private IPostService _postService;

        public ArticlesController(IPostService postService)
        {
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
        public async Task<ActionResult> GetArticlesByType(
            string? type)
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

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ActionResult> GetPost(Guid id)
        {
            PostDto result = new();
            result = result.FromPost(await _postService
                .GetPost(p => p.Id.Equals(id)));

            return result is not null
                ? Ok(result)
                : NoContent();
        }

        [HttpGet]
        [Route("additional-content/{id:Guid}")]
        public async Task<ActionResult> GetAdditionalContent(Guid id)
        {
            List<AdditionalContent> result = new();
            result = await _postService
                .GetAdditionalContent(id);

            return result is not null
                ? Ok(result)
                : NoContent();
        }

        [HttpGet]
        [Route("links/{id:Guid}")]
        public async Task<ActionResult> GetLinks(Guid id)
        {
            List<Link> result = new();
            result = await _postService
                .GetLinks(id);

            return result is not null
                ? Ok(result)
                : NoContent();
        }

        [HttpPut]
        [Route("ScoreUp/{id:Guid}")]
        public async Task<ActionResult> ScoreUp(Guid id)
        {
            try
            {
                await _postService.ScoreUp(id);
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
