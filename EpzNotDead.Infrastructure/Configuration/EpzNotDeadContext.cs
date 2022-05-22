using EpzNotDead.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace EpzNotDead.Infrastructure.Configuration
{
    public class EpzNotDeadContext : DbContext
    {
        public EpzNotDeadContext(DbContextOptions<EpzNotDeadContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var news = new News
            {
                Content = "Test content",
                Created = DateTime.Now,
                Id = Guid.NewGuid(),
                ShortContent = "Short",
                Title = "Test news",
            };
            var fbLink = new Link("https://www.facebook.com/elektropunkz", "Facebook", news.Id);
            var tLink = new Link("https://t.me/epznotdead", "Telegram channel", news.Id);
            modelBuilder.Entity<News>().HasData(news);
            modelBuilder.Entity<Link>().HasData(fbLink);
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<News> News { get; set; }
    }
}
