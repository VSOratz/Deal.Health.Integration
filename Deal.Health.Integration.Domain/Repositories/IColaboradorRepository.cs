using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IColaboradorRepository
    {
        Task<IEnumerable<ColaboradorQueryResult>> ListarAsync();
        Task<Colaborador> ObterEntidadeAsync(int id);
    }
}
