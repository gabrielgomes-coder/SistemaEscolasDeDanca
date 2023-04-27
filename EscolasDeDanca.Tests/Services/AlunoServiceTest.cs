using EscolasDeDanca.Repository.AlunosRepositories;
using EscolasDeDanca.Services.AlunosServices;
using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

namespace EscolasDeDanca.Tests.Services;

public class AlunoServiceTest
{
    private readonly IAlunoService _service;
    private readonly Mock<IAlunoRepository> _repository;

    public AlunoServiceTest()
    {
        _repository = new Mock<IAlunoRepository>();
        _service = new AlunoService(
                _repository.Object
            );
    }

    [Fact(DisplayName = "CreateAlunoAsync: 01 - Deve utilizar o AlunoRepository para criar um novo aluno")]
    public async Task CreateAlunoAsync_RepositoryCalled_CreatesNewAluno()
    {
        TbAlunos aluno = AlunoTestDataBuilder.CreateValidAluno();

        await _service.CreateAlunoAsync(aluno);

        _repository.Verify(
                       r => r.CreateAlunoAsync(aluno),
                                  Times.Once
                                         );
    }

    [Fact(DisplayName = "CreateAlunoAsync: 02 - Deve retornar o aluno criado corretamente")]
    public async Task CreateAlunoAsync_ValidAluno_ReturnsCreatedAluno()
    {
        TbAlunos alunoEsperado = AlunoTestDataBuilder.CreateValidAluno();

        _repository
            .Setup(r => r.CreateAlunoAsync(alunoEsperado))
            .ReturnsAsync(alunoEsperado);

        TbAlunos alunoRetornado = await _service.CreateAlunoAsync(alunoEsperado);

        Assert.Same(alunoEsperado, alunoRetornado);

    }

    [Fact(DisplayName = "CreateAlunoAsync: 03 - Deve retornar um erro caso o cpf seja invalido")]
    public async Task CreateAlunoAsync_InvalidCpf_ThrowsArgumentException()
    {
        TbAlunos alunoCpfInvalido = AlunoTestDataBuilder.CreatAlunoInvalidCpf();

        await Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAlunoAsync(alunoCpfInvalido));
    }


    [Fact(DisplayName = "CreateAlunoAsync: 04 - Deve retornar um erro caso o email seja invalido")]
    public async Task CreateAlunoAsync_InvalidEmail_ThrowsArgumentException()
    {
        TbAlunos alunoEmailInvalido = AlunoTestDataBuilder.CreatAlunoInvalidEmail();

        await Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAlunoAsync(alunoEmailInvalido));
    }


    [Fact(DisplayName = "CreateAlunoAsync: 05 - Deve retornar um erro caso a data de nascimento seja invalido")]
    public async Task CreateAlunoAsync_InvalidDateOfBirth_ThrowsArgumentException()
    {
        TbAlunos alunoDataNascimentoInvalido = AlunoTestDataBuilder.CreatAlunoInvalidDate();

        await Assert.ThrowsAsync<ArgumentException>(() => _service.CreateAlunoAsync(alunoDataNascimentoInvalido));
    }
}
