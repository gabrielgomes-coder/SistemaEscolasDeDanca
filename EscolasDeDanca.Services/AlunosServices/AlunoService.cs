using EscolasDeDanca.Repository.AlunosRepositories;
using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;
using System.Text.RegularExpressions;

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
        if (!CpfIsValid(aluno.Cpf) || !EmailIsValid(aluno.Email) || aluno.DataNascimento > DateTime.Now)
            throw new ArgumentException("Dados inválidos");

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

    private bool CpfIsValid(long cpf)
    {
        string cpfStr = cpf.ToString("D11");

        if (cpfStr.Length != 11 || cpfStr.All(c => c == cpfStr[0]))
        {
            return false;
        }

        int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int primeiroDigito = CalcularDigito(cpfStr.Substring(0, 9), multiplicadoresPrimeiroDigito);
        int segundoDigito = CalcularDigito(cpfStr.Substring(0, 9) + primeiroDigito, multiplicadoresSegundoDigito);

        return cpfStr.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
    }

    private int CalcularDigito(string cpfPartial, int[] multiplicadores)
    {
        int soma = 0;

        for (int i = 0; i < cpfPartial.Length; i++)
        {
            soma += int.Parse(cpfPartial[i].ToString()) * multiplicadores[i];
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }

    private bool EmailIsValid(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        Regex regex = new Regex(emailPattern);

        return regex.IsMatch(email);
    }
}
