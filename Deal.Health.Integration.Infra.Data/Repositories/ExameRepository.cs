using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class ExameRepository : IExameRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public ExameRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<ExameQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<ExameQueryResult>(ExameQueries.LISTAR);
            return response;
        }
        
        public async Task<Exame> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Exame>(ExameQueries.OBTER, param);
            return retorno;
        }
    }
}
