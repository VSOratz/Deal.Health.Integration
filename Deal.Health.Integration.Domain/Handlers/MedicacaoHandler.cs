using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class MedicacaoHandler : Notifiable<Notification>
    {
        private readonly IMedicacaoRepository repository;
        public MedicacaoHandler(IMedicacaoRepository repository)
        {
            this.repository = repository;
        }
    }
}
