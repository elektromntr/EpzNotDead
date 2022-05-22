using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpzNotDead.Infrastructure.Entities
{
    public class News : EntityBase
    {
        public string Content { get; set; } = "";
        public string ShortContent { get; set; } = "";
        [NotMapped]
        public ICollection<Link>? Links { get; set; } = new List<Link>();
    }
}
