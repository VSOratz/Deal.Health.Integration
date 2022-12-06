using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Alergia;
using Deal.Health.Integration.Domain.Queries.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Repositories
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<PacienteQueryResult>> ListarAsync();
        Task<int> SalvarAsync(Paciente paciente);
        Task<int> AtualizarAsync(Paciente paciente);
        Task DeletarAsync(int id);
        Task<Paciente> ObterEntidadeAsync(int id);
        Task<Paciente> ObterEntidadeAsync(string cpf);
    }
}
