using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Entities
{
    public class Colaborador
    {
        public Colaborador() { }
        public int Id { get; set; }
        public Instituicao Instituicao { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; }
        public string Especialidade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

        public Colaborador(int id, Instituicao instituicao, string nome, int cRM, string especialidade, string email, string senha, DateTime dataHoraCriacao, DateTime? dataHoraModificacao, DateTime? dataHoraExclusao)
        {
            Id = id;
            Instituicao = instituicao;
            Nome = nome;
            CRM = cRM;
            Especialidade = especialidade;
            Email = email;
            Senha = senha;
            DataHoraCriacao = dataHoraCriacao;
            DataHoraModificacao = dataHoraModificacao;
            DataHoraExclusao = dataHoraExclusao;
        }
    }
}