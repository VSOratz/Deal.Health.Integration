using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class DoencaHandler : Notifiable<Notification>
    {
        private readonly IDoencaRepository repository;
        public DoencaHandler(IDoencaRepository repository)
        {
            this.repository = repository;
        }
    }
}
