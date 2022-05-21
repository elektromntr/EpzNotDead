using EpzNotDead.Infrastructure.Interfaces;

namespace EpzNotDead.Infrastructure.Entities
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }
        public bool Archived { get; set; }
    }
}