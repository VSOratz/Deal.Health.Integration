using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Cirurgia;
using Deal.Health.Integration.Domain.Queries.Exame;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IExameRepository
    {
        Task<IEnumerable<ExameQueryResult>> ListarAsync();
        Task<Exame> ObterEntidadeAsync(int id);
    }
}
