using Microsoft.AspNetCore.Components;
using EpzNotDead.Infrastructure.Entities;
using System.Net.Http.Json;
using EpzNotDead.Infrastructure.Enums;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class MusicBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        protected List<Post>? Posts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Posts = await Http.GetFromJsonAsync<List<Post>>($"Articles/{PostType.Music}");
        }
    }
}
