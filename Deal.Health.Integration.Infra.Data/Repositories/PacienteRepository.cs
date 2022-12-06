using Deal.Health.Integration.Domain.Queries.Paciente;
using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Dapper;
using Deal.Health.Integration.Infra.Data.Queries;
using Deal.Health.Integration.Domain.Entities;
using Deal.Health.Integration.Domain.Queries.Alergia;

namespace Deal.Health.Integration.Infra.Data.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DbContext _context;
        private readonly DynamicParameters param;

        public PacienteRepository(DbContext context)
        {
            _context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<PacienteQueryResult>> ListarAsync()
        {
            var response = await _context.Connection.QueryAsync<PacienteQueryResult>(PacienteQueries.LISTAR);
            return response;
        }
        public async Task<int> SalvarAsync(Paciente paciente)
        {

            param.Add("@Nome", paciente.Nome);
            param.Add("@CPF", paciente.CPF);
            param.Add("@Telefone", paciente.Telefone);
            param.Add("@Email", paciente.Email);
            param.Add("@Sexo", paciente.Sexo);
            param.Add("@DataNascimento", paciente.DataNascimento);
            param.Add("@EstadoCivil", paciente.EstadoCivil);
            param.Add("@Profissao", paciente.Profissao);
            param.Add("@NrSUS", paciente.NrSUS);
            param.Add("@Endereco", paciente.Endereco);
            param.Add("@Cidade", paciente.Cidade);
            param.Add("@CEP", paciente.CEP);
            param.Add("@UF", paciente.UF);
            param.Add("@DataHoraCriacao", DateTime.UtcNow.AddHours(-3));
            param.Add("@DataHoraModificacao", DateTime.UtcNow.AddHours(-3));

            return await _context.Connection.ExecuteScalarAsync<int>(PacienteQueries.SALVAR, param);
        }

        public async Task<int> AtualizarAsync(Paciente paciente)
        {

            param.Add("@Id", paciente.Id);
            param.Add("@Nome", paciente.Nome);
            param.Add("@CPF", paciente.CPF);
            param.Add("@Telefone", paciente.Telefone);
            param.Add("@Email", paciente.Email);
            param.Add("@Sexo", paciente.Sexo);
            param.Add("@DataNascimento", paciente.DataNascimento);
            param.Add("@EstadoCivil", paciente.EstadoCivil);
            param.Add("@Profissao", paciente.Profissao);
            param.Add("@NrSUS", paciente.NrSUS);
            param.Add("@Endereco", paciente.Endereco);
            param.Add("@Cidade", paciente.Cidade);
            param.Add("@CEP", paciente.CEP);
            param.Add("@UF", paciente.UF);
            param.Add("@DataHoraModificacao", DateTime.UtcNow.AddHours(-3));

            return await _context.Connection.ExecuteScalarAsync<int>(PacienteQueries.ATUALIZAR, param);
        }

        public async Task<Paciente> ObterEntidadeAsync(int id)
        {
            param.Add("@Id", id);
            var retorno = await _context.Connection.QueryFirstOrDefaultAsync<Paciente>(PacienteQueries.OBTER, param);
            return retorno;
        }

        public async Task DeletarAsync(int id)
        {
            param.Add("@Id", id);
            param.Add("@DataHoraExclusao", DateTime.UtcNow.AddHours(-3));

            await _context.Connection.ExecuteScalarAsync<int>(PacienteQueries.DELETAR, param);
        }

    }
}
