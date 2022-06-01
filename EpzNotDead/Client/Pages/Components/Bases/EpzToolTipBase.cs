using EpzNotDead.Client.StateServices;
using Microsoft.AspNetCore.Components;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class EpzToolTipBase : ComponentBase, IDisposable
    {
        [Inject]
        protected EpzToolTipState State { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        [CascadingParameter(Name = "PlusDescription")]
        public string Description { get; set; }

        private async Task State_StateChanged(ComponentBase source, Guid id, string pro)
        {
            if (source != this && id == Id)
            {
                await InvokeAsync(StateHasChanged);
            }
        }

        protected override void OnInitialized()
        {
            State.StateChanged += async (source, id, property) => await State_StateChanged(source, id, property);
        }

        void IDisposable.Dispose()
        {
            State.StateChanged -= async (source, id, property) => await State_StateChanged(source, id, property);
        }
    }
}
