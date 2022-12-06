using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Entities
{
    public class Paciente
    {
        public Paciente() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Profissao { get; set; }
        public int NrSUS { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

        public Paciente(int id, string nome, string cPF, string telefone, string email, string sexo, DateTime dataNascimento, string estadoCivil, string profissao, int nrSUS, string endereco, string cidade, string cEP, string uF)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            EstadoCivil = estadoCivil;
            Profissao = profissao;
            NrSUS = nrSUS;
            Endereco = endereco;
            Cidade = cidade;
            CEP = cEP;
            UF = uF;
        }
    }
}