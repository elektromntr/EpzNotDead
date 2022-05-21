namespace EpzNotDead.Infrastructure.Entities
{
    public class News : EntityBase
    {
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}
