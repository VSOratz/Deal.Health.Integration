using Deal.Health.Integration.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Deal.Health.Integration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradorController : ControllerBase
    {
        // private readonly ColaboradorHandler handler;
        private readonly IColaboradorRepository repository;

        public ColaboradorController(IColaboradorRepository repository)
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