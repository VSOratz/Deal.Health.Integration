using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class ColaboradorHandler : Notifiable<Notification>
    {
        private readonly IColaboradorRepository repository;
        public ColaboradorHandler(IColaboradorRepository repository)
        {
            this.repository = repository;
        }
    }
}
