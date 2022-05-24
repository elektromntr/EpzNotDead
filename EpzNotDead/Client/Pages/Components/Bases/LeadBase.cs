using Microsoft.AspNetCore.Components;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class LeadBase : ComponentBase
    {
        [Parameter]
        public Infrastructure.Entities.News? Article { get; set; }
    }
}
