using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels;
using SistemaEscolasDeDancas.EscolasDeDanca.Models.DbModels.Academico;

namespace SistemaEscolasDeDanca.EscolasDeDancas.API.Data;

public class EscolasDancaContext : DbContext
{
    public EscolasDancaContext(){ }
    public EscolasDancaContext(DbContextOptions<EscolasDancaContext> options)
        : base(options)
    {

    }

    public DbSet<TbAlunos> Alunos { get; set; }
    public DbSet<TbModalidades> Modalidades { get; set; }
    public DbSet<TbNivel> Nivel { get; set; }
    public DbSet<Tbprofessores> Professores { get; set; }
    public DbSet<Tbturmas> Turmas { get; set; } 
    public DbSet<TbEscolas> Escolas { get; set; }
}
