using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

namespace EscolasDeDanca.Tests.DataBuilders;

internal static class AlunoTestDataBuilder
{
    public static TbAlunos CreateValidAluno()
    {
        return new TbAlunos
        {
            IdAluno = 1,
            NomeAluno = "João Silva",
            DataNascimento = new DateTime(1990, 1, 1),
            Sexo = "Masculino",
            Cpf = 12345678901,
            Endereco = "Rua das Flores, 123",
            Telefone = 1234567890,
            Email = "joao.silva@email.com",
            IdEscola = 1,
            IdMatricula = 1,
            Ativo = true
        };
    }
}
