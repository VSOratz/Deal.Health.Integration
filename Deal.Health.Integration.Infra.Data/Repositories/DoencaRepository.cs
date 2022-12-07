using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class DoencaRepository : IDoencaRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public DoencaRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<DoencaQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<DoencaQueryResult>(DoencaQueries.LISTAR);
            return response;
        }
        
        public async Task<Doenca> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Doenca>(DoencaQueries.OBTER, param);
            return retorno;
        }
    }
}
