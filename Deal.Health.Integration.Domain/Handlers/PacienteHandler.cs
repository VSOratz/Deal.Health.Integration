using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Deal.Health.Integration.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class PacienteHandler //: ICommandHandler<SalvarPacienteCommand>
    {
        private readonly IPacienteRepository repository;
        public PacienteHandler(IPacienteRepository repository)
        {
            this.repository = repository;
        }
    }
}
