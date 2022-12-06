using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class CirurgiaHandler : Notifiable<Notification>
    {
        private readonly ICirurgiaRepository repository;
        public CirurgiaHandler(ICirurgiaRepository repository)
        {
            this.repository = repository;
        }
    }
}
