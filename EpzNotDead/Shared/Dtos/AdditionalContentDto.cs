using EpzNotDead.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace EpzNotDead.Shared.Dtos
{
    public class AdditionalContentDto
    {
        public Guid Id { get; set; }
        [Required]
        public ContentName Name { get; set; }
        public string Content { get; set; } = "";
    }
}