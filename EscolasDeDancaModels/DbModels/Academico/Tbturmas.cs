namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

[Table("tb_turmas")]
public partial class Tbturmas
{
    [Key]
    [Column("id_turma", TypeName = "int(11)")]
    public int IdTurma { get; set; }

    [Column("id_professor", TypeName = "int(11)")]
    public int IdProfessor { get; set; }

    [Column("nome_turma", TypeName = "varchar(100)")]
    public string NomeTurma { get; set; }

    [Column("horario_inicial", TypeName = "time")]
    public TimeSpan HorarioInicial { get; set; }

    [Column("horario_final", TypeName = "time")]
    public TimeSpan HorarioFinal { get; set; }

    [Column("dias", TypeName = "varchar(100)")]
    public string DiasDaSemana { get; set; }

    [Column("data_inicio", TypeName = "date")]
    public DateTime DataInicio { get; set; }

    [Column("data_fim", TypeName = "date")]
    public DateTime DataFim { get; set; }

    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("id_modalidade", TypeName = "int(11)")]
    public int IdModalidade { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }
}
