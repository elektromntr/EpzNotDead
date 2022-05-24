using EpzNotDead.Infrastructure.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpzNotDead.Infrastructure.Entities
{
    public class News : EntityBase, IScore
    {
        public string Content { get; set; } = "";
        public string ShortContent { get; set; } = "";
        public int Score { get; set; }
        [NotMapped]
        public ICollection<Link>? Links { get; set; } = new List<Link>();
    }
}
