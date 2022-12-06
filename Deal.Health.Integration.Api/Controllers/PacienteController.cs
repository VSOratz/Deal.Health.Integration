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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id) =>
          Ok(await repository.ObterEntidadeAsync(id));

        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> GetCpfAsync(string cpf) =>
          Ok(await repository.ObterEntidadeAsync(cpf));

        [HttpPost]
        public async Task<ICommandResult> PostAsync([FromBody] SalvarPacienteCommand command)
        {
            var retorno = await handler.HandleAsync(command);
            return retorno;
        }

        [HttpPatch]
        public async Task<ICommandResult> PatchAsync([FromBody] AtualizarPacienteCommand command)
        {
            var retorno = await handler.HandleAsync(command);
            return retorno;
        }

        [HttpDelete("{id}")]
        public async Task<ICommandResult> Delete(int id)
        {
            var command = new ApagarPacienteCommand() { Id = id };
            return await handler.HandleAsync(command);
        }
    }
}