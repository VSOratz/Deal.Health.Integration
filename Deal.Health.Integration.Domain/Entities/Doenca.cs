using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal.Health.Integration.Domain.Entities
{
    public class Doenca
    {
        public Doenca() { }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

        public Doenca(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}