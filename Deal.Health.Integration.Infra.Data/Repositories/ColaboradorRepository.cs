using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public ColaboradorRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<ColaboradorQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<ColaboradorQueryResult>(ColaboradorQueries.LISTAR);
            return response;
        }
        
        public async Task<Colaborador> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Colaborador>(ColaboradorQueries.OBTER, param);
            return retorno;
        }
    }
}
