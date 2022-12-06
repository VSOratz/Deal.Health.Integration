using Deal.Health.Integration.Domain.Commands.Inputs.Paciente;
using Deal.Health.Integration.Domain.Handlers;
using Deal.Health.Integration.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using MvcContrib.PortableAreas;

namespace Deal.Health.Integration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlergiaController : ControllerBase
    {
        // private readonly AlergiaHandler handler;
        private readonly IAlergiaRepository repository;

        public AlergiaController(IAlergiaRepository repository)
        {
            //this.handler = handler;
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

        
    }
}