using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Cirurgia;
using Deal.Health.Integration.Domain.Queries.Exame;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface ICirurgiaRepository
    {
        Task<IEnumerable<CirurgiaQueryResult>> ListarAsync();
        Task<Cirurgia> ObterEntidadeAsync(int id);
    }
}
