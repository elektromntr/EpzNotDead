using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Infrastructure.Enums;
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
            //modelBuilder.Entity<Post>().HasMany<Link>().WithOne();
            //modelBuilder.Entity<Link>().HasOne<Post>().WithMany(p => p.Links).HasForeignKey("PostId");
            for (var i = 1; i < 4; i++)
            {

                var postId = Guid.NewGuid();
                var fbLink = new Link("https://www.facebook.com/elektropunkz", "Facebook", postId);
                var tLink = new Link("https://t.me/epznotdead", "Telegram channel", postId);
                var additionalContent = new AdditionalContent
                {
                    PostId = postId,
                    Id = Guid.NewGuid(),
                    Name = ContentName.Price,
                    Content = $"Test additional content {i}"
                };
                var post = new Post
                {
                    Content = $"Test content {i}",
                    Created = DateTime.Now,
                    Id = postId,
                    ShortContent = $"Short {i}",
                    Title = $"Test news {i}",
                    Type = (PostType)i,
                };
                modelBuilder.Entity<Post>().HasData(post);
                modelBuilder.Entity<Link>().HasData(fbLink);
                modelBuilder.Entity<Link>().HasData(tLink);
                modelBuilder.Entity<AdditionalContent>().HasData(additionalContent);
            }
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AdditionalContent> AdditionalContent { get; set; }
    }
}
