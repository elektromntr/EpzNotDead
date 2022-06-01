using Microsoft.AspNetCore.Components;

namespace EpzNotDead.Client.StateServices
{
    public class EpzToolTipState
    {
        public string Description { get; private set; } = "";
        public string Subject { get; private set; } = "";
        public bool Display { get;private set; }

        public Task UpdateDescription(
            ComponentBase source, Guid id, string description)
        {
            this.Description = description;
            NotifyStateChanged(source, id, "Description");
            return Task.CompletedTask;
        }

        public Task ClearDescription(
            ComponentBase Source, Guid id, bool instant = false)
        {
            if (!instant) Thread.Sleep(1000);
            Description = string.Empty;
            NotifyStateChanged(Source, id, "");
            return Task.CompletedTask;
        }

        public event Action<ComponentBase, Guid, string> StateChanged;

        private void NotifyStateChanged(
            ComponentBase source, Guid id, string property) 
                => StateChanged?.Invoke(source, id, property);
    }
}
