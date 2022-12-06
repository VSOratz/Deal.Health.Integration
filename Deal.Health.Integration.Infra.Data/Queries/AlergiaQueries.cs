namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class AlergiaQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                Descricao,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao
            FROM Alergia 
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
			FROM Alergia
            WHERE id = @Id
            AND DataHoraExclusao is null;";
    }
}
