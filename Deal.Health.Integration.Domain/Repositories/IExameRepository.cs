using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IExameRepository
    {
        Task<IEnumerable<ExameQueryResult>> ListarAsync();
        Task<Exame> ObterEntidadeAsync(int id);
    }
}
