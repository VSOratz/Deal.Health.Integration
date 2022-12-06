using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Flunt.Validations;

namespace Deal.Health.Integration.Domain.Commands.Contracts.Paciente
{
    public class ApagarPacienteContracts : Contract<ApagarPacienteCommand>
    {
        public ApagarPacienteContracts(ApagarPacienteCommand command)
        {
            Requires().IsGreaterThan(command.Id, 0, "Id", "O Id do paciente deve ser informado e maior que zero.");
        }
    }
}
