using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpzNotDead.Shared.Dtos
{
    public class PostDto : EntityBase
    {
        public string Content { get; set; } = "";
        public string ShortContent { get; set; } = "";
        public int Score { get; set; }
        public PostType Type { get; set; }
        public ICollection<AdditionalContentDto>? AdditionalContent { get; set; } = new List<AdditionalContentDto>();
        public ICollection<LinkDto>? Links { get; set; } = new List<LinkDto>();

        public PostDto FromPost(Post source)
        {
            var result = new PostDto
            {
                Id = source.Id,
                AdditionalContent = source.AdditionalContent
                .Select(c => new AdditionalContentDto
                {
                    Content = c.Content,
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList(),
                Content = source.Content,
                Created = source.Created,
                Edited = source.Edited,
                Score = source.Score,
                ShortContent = source.ShortContent,
                Title = source.Title,
                Type = source.Type,
                Links = source.Links
                .Select(l => new LinkDto
                {
                    Id = l.Id,
                    Title = l.Title,
                    Url = l.Url
                }).ToList()
            };
            return result;
        }
    }
}
