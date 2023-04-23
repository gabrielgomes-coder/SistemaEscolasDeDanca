namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

[Table("tb_modalidades")]
public class TbModalidades
{
    [Column("id_modalidade", TypeName = "int(11)")]
    public int IdModalidade { get; set; }

    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("nome_modalidade", TypeName = "varchar(100)")]
    public string NomeModalidade { get; set; }

    [Column("id_nivel", TypeName = "int(11)")]
    public int IdNivel { get; set; }

    [Column("valor", TypeName = "decimal(10,2)")]
    public decimal Valor { get; set; }

    [Column("descricao", TypeName = "varchar(100)")]
    public string Descricao { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }

}
