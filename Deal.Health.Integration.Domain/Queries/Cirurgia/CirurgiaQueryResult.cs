namespace Deal.Health.Integration.Domain.Queries.Cirurgia
{
    public class CirurgiaQueryResult
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

    }
}
