using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

namespace EscolasDeDanca.Services.AlunosServices;

public interface IAlunoService
{
    Task<TbAlunos> GetAlunoAsync(int id);
    Task<IEnumerable<TbAlunos>> GetAlunosAsync();
    Task<TbAlunos> CreateAlunoAsync(TbAlunos aluno);
    Task<TbAlunos> UpdateAlunoAsync(TbAlunos aluno);
    Task<TbAlunos> DeleteAlunoAsync(int id);
}
