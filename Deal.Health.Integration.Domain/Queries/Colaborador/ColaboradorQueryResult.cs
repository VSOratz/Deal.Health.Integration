namespace Deal.Health.Integration.Domain.Queries
{
    public class ColaboradorQueryResult
    {
        public int Id { get; set; }
        //public Instituicao Instituicao { get; set; }
        public string Nome { get; set; }
        public int CRM { get; set; }
        public string Especialidade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime? DataHoraModificacao { get; set; }
        public DateTime? DataHoraExclusao { get; set; }

    }
}
