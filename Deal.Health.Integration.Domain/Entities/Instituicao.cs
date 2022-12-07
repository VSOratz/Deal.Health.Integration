namespace Deal.Health.Integration.Domain.Entities
{
    public class Instituicao
    {
        public Instituicao() { }
        public int Id { get; set; }
        public string Nome { get; set; }

        public Instituicao(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}