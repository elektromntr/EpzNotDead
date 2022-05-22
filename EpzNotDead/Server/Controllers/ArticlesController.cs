using Microsoft.AspNetCore.Mvc;
using EpzNotDead.Infrastructure.Configuration;

namespace EpzNotDead.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private EpzNotDeadContext _db;

        public ArticlesController(EpzNotDeadContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet]
        [Route("News")]
        public async Task<ActionResult> GetNews()
        {
            var result = _db.News.ToList();

            return Ok(result);
        }
    }
}
