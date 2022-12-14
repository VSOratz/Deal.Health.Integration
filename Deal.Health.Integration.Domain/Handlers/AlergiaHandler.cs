using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class AlergiaHandler : Notifiable<Notification>
    {
        private readonly IAlergiaRepository repository;
        public AlergiaHandler(IAlergiaRepository repository)
        {
            this.repository = repository;
        }
    }
}
