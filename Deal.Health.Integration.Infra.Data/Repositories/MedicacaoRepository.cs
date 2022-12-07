using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class MedicacaoRepository : IMedicacaoRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public MedicacaoRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<MedicacaoQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<MedicacaoQueryResult>(MedicacaoQueries.LISTAR);
            return response;
        }
        
        public async Task<Medicacao> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Medicacao>(MedicacaoQueries.OBTER, param);
            return retorno;
        }
    }
}
