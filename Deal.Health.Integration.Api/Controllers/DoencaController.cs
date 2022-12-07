using Deal.Health.Integration.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Deal.Health.Integration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoencaController : ControllerBase
    {
        // private readonly AlergiaHandler handler;
        private readonly IDoencaRepository repository;

        public DoencaController(IDoencaRepository repository)
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