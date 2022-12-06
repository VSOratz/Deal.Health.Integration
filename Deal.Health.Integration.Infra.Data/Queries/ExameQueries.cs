namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class ExameQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                Descricao,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao
            FROM Exame 
            WHERE DataHoraExclusao IS NULL
            ORDER BY Descricao ASC;
        ";

        public const string OBTER =
        @" 
            SELECT
                Id,
                Descricao,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao             
			FROM Exame
            WHERE id = @Id
            AND DataHoraExclusao is null;";
    }
}
