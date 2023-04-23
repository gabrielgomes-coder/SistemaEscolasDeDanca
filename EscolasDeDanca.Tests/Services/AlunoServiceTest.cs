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
    public async Task CreateAlunoAsync_01()
    {
        TbAlunos aluno = AlunoTestDataBuilder.CreateValidAluno();

        await _service.CreateAlunoAsync(aluno);

        _repository.Verify(
                       r => r.CreateAlunoAsync(aluno),
                                  Times.Once
                                         );
    }

    [Fact(DisplayName = "CreateAlunoAsync: 02 - Deve retornar o aluno criado corretamente")]
    public async Task CreateAlunoAsync_02()
    {
        TbAlunos alunoEsperado = AlunoTestDataBuilder.CreateValidAluno();

        _repository
            .Setup(r => r.CreateAlunoAsync(alunoEsperado))
            .ReturnsAsync(alunoEsperado);

        TbAlunos alunoRetornado = await _service.CreateAlunoAsync(alunoEsperado);

        Assert.Same(alunoEsperado, alunoRetornado);

    }
}
