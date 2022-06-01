using EpzNotDead.Client.StateServices;
using Microsoft.AspNetCore.Components;

namespace EpzNotDead.Client.Pages.Components.Bases
{
    public class FooterBase : ComponentBase
    {
        #region INJECTS
        
        [Inject]
        protected HttpClient Client { get; set; }
        [Inject]
        protected EpzToolTipState ToolTipState { get; set; }

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

        protected async Task ScoreUp(Guid id)
        {
            Score++;
            await Client.PutAsync($"Articles/ScoreUp/{id}", null);
        }

        protected Task PassDescriptionToEpzToolTip(Guid id,
            DescriptionSubject subject)
        {
            string description = string.Empty;
            switch (subject)
            { 
                case DescriptionSubject.ScoreUp:
                    description = "Ten post może dostać od Ciebie plusa. Nie zapisujemy Twoich danych, ani żadnych Twoich preferencji, tak jak robią to media społecznościowe. W ten sposób chcemy tylko dać innym znak, że warto to przeczytać.";
                    break;
                default:
                    break;
            }
            ToolTipState.UpdateDescription(this, id, description);
            return Task.CompletedTask;
        }

        protected Task ClearDescription(Guid id)
        {
            ToolTipState.ClearDescription(this, id, false);
            return Task.CompletedTask;
        }
    }
}
