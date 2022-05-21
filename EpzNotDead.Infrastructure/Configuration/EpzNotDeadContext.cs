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

            modelBuilder.Entity<Link>().HasData(new Link
            {
                Created = DateTime.Now,
                Edited = DateTime.Now,
                Id = Guid.NewGuid(),
                Title = "Facebook",
                Url = "https://www.facebook.com/elektropunkz"
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                Created = DateTime.Now,
                Edited = DateTime.Now,
                Id = Guid.NewGuid(),
                Title = "Telegram channel",
                Url = "https://t.me/epznotdead"
            });
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<News> News { get; set; }
    }
}
