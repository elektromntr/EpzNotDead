using EpzNotDead.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace EpzNotDead.Infrastructure.Entities
{
    public class AdditionalContent
    {
        public Guid Id { get; set; }
        [Required]
        public ContentName Name { get; set; }
        public string Content { get; set; } = "";
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}