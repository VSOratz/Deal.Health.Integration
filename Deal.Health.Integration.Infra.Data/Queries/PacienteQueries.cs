namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class PacienteQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                Nome 
            FROM Paciente 
            WHERE DataExclusao IS NULL
            ORDER BY Nome ASC;
        ";
    }
}
