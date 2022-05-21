using System.ComponentModel.DataAnnotations.Schema;

namespace EpzNotDead.Infrastructure.Entities
{
    public class Link : EntityBase
    {
        public string Url { get; set; }
    }
}