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
    public class AlergiaHandler : Notifiable<Notification>
    {
        private readonly IAlergiaRepository repository;
        public AlergiaHandler(IAlergiaRepository repository)
        {
            this.repository = repository;
        }
    }
}
