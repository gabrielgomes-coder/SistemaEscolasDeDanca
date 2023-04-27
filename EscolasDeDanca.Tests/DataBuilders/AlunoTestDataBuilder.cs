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
            Cpf = 74084358088,
            Endereco = "Rua das Flores, 123",
            Telefone = 1234567890,
            Email = "joao.silva@email.com",
            IdEscola = 1,
            IdMatricula = 1,
            Ativo = true
        };
    }

    public static TbAlunos CreatAlunoInvalidCpf()
    {
        return new TbAlunos
        {
            IdAluno = 1,
            NomeAluno = "João Silva",
            DataNascimento = new DateTime(1990, 1, 1),
            Sexo = "Masculino",
            Cpf = 123456781,
            Endereco = "Rua das Flores, 123",
            Telefone = 1234567890,
            Email = "joao.silva@email.com",
            IdEscola = 1,
            IdMatricula = 1,
            Ativo = true
        };
    }

    public static TbAlunos CreatAlunoInvalidEmail()
    {
        return new TbAlunos
        {
            IdAluno = 1,
            NomeAluno = "João Silva",
            DataNascimento = new DateTime(1990, 1, 1),
            Sexo = "Masculino",
            Cpf = 74084358088,
            Endereco = "Rua das Flores, 123",
            Telefone = 1234567890,
            Email = "joao.silv123aai@l.cm.",
            IdEscola = 1,
            IdMatricula = 1,
            Ativo = true
        };
    }

    public static TbAlunos CreatAlunoInvalidDate()
    {
        return new TbAlunos
        {
            IdAluno = 1,
            NomeAluno = "João Silva",
            DataNascimento = new DateTime(2024, 1, 1),
            Sexo = "Masculino",
            Cpf = 74084358088,
            Endereco = "Rua das Flores, 123",
            Telefone = 1234567890,
            Email = "joao.silva@email.com",
            IdEscola = 1,
            IdMatricula = 1,
            Ativo = true
        };
    }
}
