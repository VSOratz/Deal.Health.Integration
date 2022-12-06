using Deal.Health.Integration.Domain.Queries.Paciente;
using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Alergia;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class AlergiaRepository : IAlergiaRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public AlergiaRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<AlergiaQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<AlergiaQueryResult>(AlergiaQueries.LISTAR);
            return response;
        }
        
        public async Task<Alergia> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Alergia>(AlergiaQueries.OBTER, param);
            return retorno;
        }
    }
}
