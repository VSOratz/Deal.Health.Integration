using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IMedicacaoRepository
    {
        Task<IEnumerable<MedicacaoQueryResult>> ListarAsync();
        Task<Medicacao> ObterEntidadeAsync(int id);
    }
}
