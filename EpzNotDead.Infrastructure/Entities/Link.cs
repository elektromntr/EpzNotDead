using System.ComponentModel.DataAnnotations;

namespace EpzNotDead.Infrastructure.Entities
{
    public class Link : EntityBase
    {
        public Link(string url, string title, Guid referenceId)
        {
            Url = url;
            Title = title;
            Created = DateTime.Now;
            Id = Guid.NewGuid();
            ReferenceId = referenceId;
        }
        [Required]
        public string Url { get; set; }
        [Required]
        public Guid ReferenceId { get; set; }
    }
}