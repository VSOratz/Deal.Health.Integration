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


        public const string ATUALIZAR =
        @"UPDATE paciente
                SET 
                    Nome = @Nome,
	                CPF = @CPF,
	                Telefone = @Telefone,
	                Email = @Email,
	                Sexo = @Sexo,
	                DataNascimento = @DataNascimento,
	                EstadoCivil = @EstadoCivil,
	                Profissao = @Profissao,
	                NrSUS = @NrSUS,
	                Endereco = @Endereco,
	                Cidade = @Cidade,
	                CEP = @CEP,
	                UF = @UF,
	                DataHoraModificacao = @DataHoraModificacao
                WHERE Id = @Id;";

        public const string OBTER =
        @" 
            SELECT
                *              
			FROM Paciente
            WHERE id = @Id
            AND c.DataHoraExclusao is null;";

        public const string DELETAR =
        @"UPDATE Paciente
                SET DataHoraExclusao = @DataExclusao
                WHERE Id = @Id;";
    }
}
