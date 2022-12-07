using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IDoencaRepository
    {
        Task<IEnumerable<DoencaQueryResult>> ListarAsync();
        Task<Doenca> ObterEntidadeAsync(int id);
    }
}
