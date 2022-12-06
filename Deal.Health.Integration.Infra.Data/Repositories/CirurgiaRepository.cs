using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Cirurgia;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class CirurgiaRepository : ICirurgiaRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public CirurgiaRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<CirurgiaQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<CirurgiaQueryResult>(CirurgiaQueries.LISTAR);
            return response;
        }
        
        public async Task<Cirurgia> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Cirurgia>(CirurgiaQueries.OBTER, param);
            return retorno;
        }
    }
}
