using Microsoft.EntityFrameworkCore;

public class MeuMVPContext : DbContext
{
    public MeuMVPContext(DbContextOptions<MeuMVPContext> options)
        : base(options)
    {
    }

    public DbSet<Evento> Evento { get; set; }
}
