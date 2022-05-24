using Microsoft.AspNetCore.Components;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class FooterBase : ComponentBase
    {
        #region INJECTS
        
        [Inject]
        protected HttpClient Client { get; set; }

        #endregion

        #region PARAMETERS

        [Parameter]
        public Guid Id { get; set; }
        [Parameter]
        public DateTime Created { get; set; }
        [Parameter]
        public DateTime? Edited { get; set; }
        [Parameter]
        public int Score { get; set; } = 3;

        #endregion

        protected async Task GivePlus(Guid id)
        {
            Score++;
            await Client.PutAsync($"Articles/ScoreUp/{id}", null);
        }
    }
}
