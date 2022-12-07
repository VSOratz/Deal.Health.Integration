using Deal.Health.Integration.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Deal.Health.Integration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstituicaoController : ControllerBase
    {
        // private readonly InstituicaoHandler handler;
        private readonly IInstituicaoRepository repository;

        public InstituicaoController(IInstituicaoRepository repository)
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

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetAsync(string nome) =>
          Ok(await repository.ObterEntidadeAsync(nome));


    }
}