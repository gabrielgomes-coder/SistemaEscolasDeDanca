namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

[Table("tb_professores")]
public partial class Tbprofessores
{
    [Key]
    [Column("id_professor", TypeName = "Int(11)")]
    public int IdProfessor { get; set; }

    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("nome_professor", TypeName = "varchar(100)")]
    public string NomeProfessor { get; set; }

    [Column("data_nascimento", TypeName = "date")]
    public DateTime DataNascimento { get; set; }

    [Column("sexo", TypeName = "varchar(30)")]
    public string Sexo { get; set; }

    [Column("cpf", TypeName = "int")]
    public int Cpf { get; set; }

    [Column("endereco", TypeName = "varchar(100)")]
    public string Endereco { get; set; }

    [Column("telefone", TypeName = "int")]
    public int Telefone { get; set; }

    [Column("email", TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }
}
