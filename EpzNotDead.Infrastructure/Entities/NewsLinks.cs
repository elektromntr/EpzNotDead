namespace EpzNotDead.Infrastructure.Entities
{
    public class NewsLinks
    {
        public Guid NewsId { get; set; }
        public Guid LinkId { get; set; }

        public virtual News News { get; set; }
        public virtual Link Link { get; set; }
    }
}
