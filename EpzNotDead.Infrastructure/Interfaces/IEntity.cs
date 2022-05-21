namespace EpzNotDead.Infrastructure.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }
        public bool Archived { get; set; }
    }
}
