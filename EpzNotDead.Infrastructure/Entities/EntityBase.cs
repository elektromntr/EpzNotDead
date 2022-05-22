using EpzNotDead.Infrastructure.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EpzNotDead.Infrastructure.Entities
{
    public abstract class EntityBase : IEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }
        public bool Archived { get; set; }
    }
}