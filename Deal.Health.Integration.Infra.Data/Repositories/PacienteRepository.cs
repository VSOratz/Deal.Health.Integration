using Deal.Health.Integration.Domain.Queries.Paciente;
using Deal.Health.Integration.Domain.Repositories;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public async Task<IEnumerable<PacienteQueryResult>> ListarAsync()
        {

            //await context.Connection.QueryAsync<ClienteQueryResult>(ClienteQueries.LISTAR);
            return new PacienteQueryResult() { };
        }
    }
}
