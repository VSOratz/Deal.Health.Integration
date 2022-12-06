using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Commands.Contracts.Paciente
{
    public class AtualizarPacienteContracts : Contract<AtualizarPacienteCommand>
    {
        public AtualizarPacienteContracts(AtualizarPacienteCommand command)
        {

            Requires().IsNotNull(command.Nome, "Nome", string.Format("O Campo é obrigatório", "Nome"));
            Requires().IsNotNullOrWhiteSpace(command.Nome, "Nome", string.Format("O Campo não pode ser vazio ou nulo", "Nome"));
            Requires().IsLowerOrEqualsThan(command.Nome, 100, "Nome", string.Format("O Campo não pode ter mais de 100 caracteres", "Nome", 100));
            Requires().IsGreaterOrEqualsThan(command.Nome, 3, "Nome", string.Format("O Campo não pode ter menos de 100 caracteres", "Nome", 3));

        }
    }
}
