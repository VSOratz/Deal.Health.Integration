namespace Deal.Health.Integration.Domain.Queries.Exame
{
    public class ExameQueryResult
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

    }
}
