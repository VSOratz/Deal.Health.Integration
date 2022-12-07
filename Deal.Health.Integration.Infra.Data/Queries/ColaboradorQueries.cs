namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class ColaboradorQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                InstituicaoId,
                Nome,
                CRM,
                Especialidade,
                Email,
                Senha,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao
            FROM Colaborador 
            WHERE DataHoraExclusao IS NULL
            ORDER BY Descricao ASC;
        ";

        public const string OBTER =
        @" 
            SELECT
                Id,
                InstituicaoId,
                Nome,
                CRM,
                Especialidade,
                Email,
                Senha,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao         
			FROM Colaborador
            WHERE id = @Id
            AND DataHoraExclusao is null;";
    }
}
