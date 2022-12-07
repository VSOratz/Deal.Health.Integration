namespace Deal.Health.Integration.Domain.Entities
{
    public class Medicacao
    {
        public Medicacao() { }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

        public Medicacao(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}