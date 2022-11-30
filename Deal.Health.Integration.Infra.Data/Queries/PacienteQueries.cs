namespace Deal.Health.Integration.Infra.Data.Queries
{
    public static class PacienteQueries
    {
        public const string LISTAR = @"
            SELECT 
                Id,
                Nome,
                CPF,
                Telefone,
                Email,
                Sexo,
                DataNascimento,
                EstadoCivil,
                Profissao,
                NrSUS,
                Endereco,
                Cidade,
                CEP,
                UF,
                DataHoraCriacao,
                DataHoraModificacao,
                DataHoraExclusao
            FROM Paciente 
            WHERE DataHoraExclusao IS NULL
            ORDER BY Nome ASC;
        ";

        public const string SALVAR =

        @"INSERT INTO Paciente (Nome,
                                CPF,
                                Telefone,
                                Email,
                                Sexo,
                                DataNascimento,
                                EstadoCivil,
                                Profissao,
                                NrSUS,
                                Endereco,
                                Cidade,
                                CEP,
                                UF,
                                DataHoraCriacao,
                                DataHoraModificacao)
                         VALUES      (@Nome,
                                      @CPF,
                                      @Telefone,
                                      @Email,
                                      @Sexo,
                                      @DataNascimento,
                                      @EstadoCivil,
                                      @Profissao,
                                      @NrSUS,
                                      @Endereco,
                                      @Cidade,
                                      @CEP,
                                      @UF,
                                      @DataHoraCriacao,
                                      @DataHoraModificacao);
                      SELECT LAST_INSERT_ID();";
    }
}
