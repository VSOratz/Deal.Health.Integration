using Deal.Health.Integration.Domain.Commands.Contracts.Paciente;
using Flunt.Notifications;

namespace Deal.Health.Integration.Domain.Commands.Inputs.Paciente
{
    public class AtualizarPacienteCommand : Notifiable<Notification>
    {
        public AtualizarPacienteCommand()
        { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Profissao { get; set; }
        public int NrSUS { get; set; }

        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }

        public bool EhValido()
        {
            AddNotifications(new AtualizarPacienteContracts(this));
            return IsValid;
        }
    }
}
