using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public InstituicaoRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<InstituicaoQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<InstituicaoQueryResult>(InstituicaoQueries.LISTAR);
            return response;
        }

        public async Task<Instituicao> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Instituicao>(InstituicaoQueries.OBTER, param);
            return retorno;
        }

        public async Task<Instituicao> ObterEntidadeAsync(string nome)
        {
            param.Add("@Nome", nome);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Instituicao>(InstituicaoQueries.OBTER_NOME, param);
            return retorno;
        }
    }
}
