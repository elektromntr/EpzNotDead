using EpzNotDead.Infrastructure.Entities;
using EpzNotDead.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class PostDetailsBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        protected PostDto Post { get; set; } = new PostDto();

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Post = await Http.GetFromJsonAsync<PostDto>($"Articles/{Id}");
        }
    }
}
