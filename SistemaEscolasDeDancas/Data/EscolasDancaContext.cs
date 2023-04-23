namespace SistemaEscolasDeDanca.EscolasDeDancas.API.Data;

public class EscolasDancaContext : DbContext
{
    public EscolasDancaContext(){ }
    public EscolasDancaContext(DbContextOptions<EscolasDancaContext> options)
        : base(options)
    {

    }
}
