using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Alergia;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IAlergiaRepository
    {
        Task<IEnumerable<AlergiaQueryResult>> ListarAsync();
        Task<Alergia> ObterEntidadeAsync(int id);
    }
}
