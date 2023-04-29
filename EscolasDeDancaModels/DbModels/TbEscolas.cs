namespace SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels;

[Table("tb_escola")]
public partial class TbEscolas
{
    [Key]
    [Column("id_escola", TypeName = "int(11)")]
    public int IdEscola { get; set; }

    [Column("razao_social", TypeName = "varchar(100)")]
    public string RazaoSocial { get; set; }

    [Column("nome_fantasia", TypeName = "varchar(100)")]
    public string NomeFantasia { get; set; }

    [Column("cnpj", TypeName = "int")]
    public int Cnpj { get; set; }

    [Column("endereco", TypeName = "varchar(100)")]
    public string Endereco { get; set; }

    [Column("telefone", TypeName = "int")]
    public int Telefone { get; set; }

    [Column("email", TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Column("site", TypeName = "varchar(100)")]
    public string Site { get; set; }

    [Column("ativo", TypeName = "bit")]
    public bool Ativo { get; set; }

}
