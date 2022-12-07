using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface ICirurgiaRepository
    {
        Task<IEnumerable<CirurgiaQueryResult>> ListarAsync();
        Task<Cirurgia> ObterEntidadeAsync(int id);
    }
}
