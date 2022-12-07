using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class InstituicaoHandler : Notifiable<Notification>
    {
        private readonly IInstituicaoRepository repository;
        public InstituicaoHandler(IInstituicaoRepository repository)
        {
            this.repository = repository;
        }
    }
}
