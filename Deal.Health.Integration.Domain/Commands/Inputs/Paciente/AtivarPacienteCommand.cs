using Deal.Health.Integration.Domain.Commands.Contracts.Paciente;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Commands.Inputs.Paciente
{
    public class ApagarPacienteCommand : Notifiable<Notification>
    {
        public int Id { get; set; }

        public bool EhValido()
        {
            AddNotifications(new ApagarPacienteContracts(this));
            return IsValid;
        }
    }
}
