using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Deal.Health.Integration.Domain.Commands.Outputs;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Repositories;
using Flunt.Notifications;
using MvcContrib.PortableAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Handlers
{
    public class PacienteHandler : Notifiable<Notification>
    {
        private readonly IPacienteRepository repository;
        public PacienteHandler(IPacienteRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ICommandResult> HandleAsync(SalvarPacienteCommand command)
        {
            if (!command.EhValido())
            {
                AddNotifications(command.Notifications);
                return new DealHealthCommandResult(false, "Problema no cadastro do paciente!", Notifications);
            }

            var salvarPaciente = new Paciente(
                0,
                command.Nome,
                command.CPF,
                command.Telefone,
                command.Email,
                command.Sexo,
                command.DataNascimento,
                command.EstadoCivil,
                command.Profissao,
                command.NrSUS,
                command.Endereco,
                command.Cidade,
                command.CEP,
                command.UF);

            salvarPaciente.Id = await repository.SalvarAsync(salvarPaciente);

            return new DealHealthCommandResult(true, "Paciente cadastrado com sucesso!", null);
        }
    }
}
