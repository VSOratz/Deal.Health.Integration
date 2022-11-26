using Deal.Health.Integration.Domain.Queries.Paciente;
using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DbContext _context;

        public PacienteRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PacienteQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<PacienteQueryResult>(PacienteQueries.LISTAR);
            return response;
        }
    }
}
