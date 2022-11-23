using Deal.Health.Integration.Domain.Commands.Contracts.Paciente;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Commands.Inputs.Paciente
{
    public class SalvarPacienteCommand : Notifiable<Notification>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EhValido()
        {
            AddNotifications(new SalvarPacienteContracts(this));
            return IsValid;
        }
    }
}
