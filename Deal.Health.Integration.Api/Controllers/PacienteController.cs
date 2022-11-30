using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Deal.Health.Integration.Domain.Handlers;
using Deal.Health.Integration.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using MvcContrib.PortableAreas;

namespace Deal.Health.Integration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly PacienteHandler handler;
        private readonly IPacienteRepository repository;

        public PacienteController(PacienteHandler handler, IPacienteRepository repository)
        {
            this.handler = handler;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> ListarAsync()
        {
            return Ok(await repository.ListarAsync());
        }
        [HttpPost]
        public async Task<ICommandResult> PostAsync([FromBody] SalvarPacienteCommand command)
        {
            var retorno = await handler.HandleAsync(command);
            return retorno;
        }
    }
}