using EscolasDeDanca.Repository.AlunosRepositories;
using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

namespace EscolasDeDanca.Services.AlunosServices;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepository _alunoRepository;
    public AlunoService(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }

    public async Task<TbAlunos> CreateAlunoAsync(TbAlunos aluno)
    {
        return await _alunoRepository.CreateAlunoAsync(aluno);
    }

    public async Task<TbAlunos> DeleteAlunoAsync(int id)
    {
        return await _alunoRepository.DeleteAlunoAsync(id);
    }

    public async Task<TbAlunos> GetAlunoAsync(int id)
    {
        return await _alunoRepository.GetAlunoAsync(id);
    }

    public async Task<IEnumerable<TbAlunos>> GetAlunosAsync()
    {
        return await _alunoRepository.GetAlunosAsync();
    }

    public async Task<TbAlunos> UpdateAlunoAsync(TbAlunos aluno)
    {
        return await _alunoRepository.UpdateAlunoAsync(aluno);
    }
}
