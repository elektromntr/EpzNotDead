using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpzNotDead.Infrastructure.Entities
{
    public class Link : EntityBase
    {
        public Link()
        {

        }
        public Link(string url, string title, Guid postId)
        {
            Url = url;
            Title = title;
            Created = DateTime.Now;
            Id = Guid.NewGuid();
            PostId = postId;
        }
        public Link(string url, string title)
        {
            Url = url;
            Title = title;
            Created = DateTime.Now;
            Id = Guid.NewGuid();
        }
        [Required]
        public string Url { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}