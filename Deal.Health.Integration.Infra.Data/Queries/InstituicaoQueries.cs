namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class InstituicaoQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                Nome
            FROM Instituicao 
            WHERE DataHoraExclusao IS NULL
            ORDER BY Descricao ASC;
        ";

        public const string OBTER =
        @" 
            SELECT
                Id,
                Nome             
			FROM Instituicao
            WHERE id = @Id
            AND DataHoraExclusao is null;";

        public const string OBTER_NOME =
        @" 
            SELECT
                Id,
                Nome             
			FROM Instituicao
            WHERE Nome like '%@Nome%'
            AND DataHoraExclusao is null;";
    }
}
