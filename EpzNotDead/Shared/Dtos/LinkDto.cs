using System.ComponentModel.DataAnnotations;

namespace EpzNotDead.Shared.Dtos
{
    public class LinkDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        [Required]
        public string Url { get; set; }
    }
}