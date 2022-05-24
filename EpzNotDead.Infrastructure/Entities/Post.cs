using EpzNotDead.Infrastructure.Enums;
using EpzNotDead.Infrastructure.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpzNotDead.Infrastructure.Entities
{
    public class Post : EntityBase, IScore
    {
        public string Content { get; set; } = "";
        public string ShortContent { get; set; } = "";
        public int Score { get; set; }
        public PostType Type { get; set; }
        public ICollection<AdditionalContent>? AdditionalContent { get; set; } = new List<AdditionalContent>();
        public ICollection<Link>? Links { get; set; } = new List<Link>();
    }
}
