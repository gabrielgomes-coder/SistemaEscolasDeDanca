namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

[Table("tb_nivel")]
public partial class TbNivel
{
    [Column("id_nivel", TypeName = "int(11)")]
    public int IdNivel { get; set; }

    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("nome_nivel", TypeName = "varchar(100)")]
    public string NomeNivel { get; set; }

    [Column("idade_minima", TypeName = "int(11)")]
    public int IdadeMinima { get; set; }

    [Column("idade_maxima", TypeName = "int(11)")]
    public int IdadeMaxima { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }
}
