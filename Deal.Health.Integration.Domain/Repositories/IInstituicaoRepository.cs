using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IInstituicaoRepository
    {
        Task<IEnumerable<InstituicaoQueryResult>> ListarAsync();
        Task<Instituicao> ObterEntidadeAsync(int id);
        Task<Instituicao> ObterEntidadeAsync(string nome);
    }
}
