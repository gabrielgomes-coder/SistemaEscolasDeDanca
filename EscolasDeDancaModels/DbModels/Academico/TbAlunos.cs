namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

[Table("tb_alunos")]
public partial class TbAlunos
{
    [Key]
    [Column("id_aluno", TypeName = "int(11)")]
    public int IdAluno { get; set; }

    [Column("nome_aluno", TypeName = "varchar(100)")]
    public string NomeAluno { get; set; }

    [Column("data_nascimento", TypeName = "date")]
    public DateTime DataNascimento { get; set; }

    [Column("sexo", TypeName = "varchar(30)")]
    public string Sexo { get; set; }

    [Column("cpf", TypeName = "bigint")]
    public long Cpf { get; set; }

    [Column("endereco", TypeName = "varchar(100)")]
    public string Endereco { get; set; }

    [Column("telefone", TypeName = "int")]
    public int Telefone { get; set; }

    [Column("email", TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("id_matricula", TypeName = "int(11)")]
    public int IdMatricula { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }
}
