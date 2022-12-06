using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class ExameHandler : Notifiable<Notification>
    {
        private readonly IExameRepository repository;
        public ExameHandler(IExameRepository repository)
        {
            this.repository = repository;
        }
    }
}
