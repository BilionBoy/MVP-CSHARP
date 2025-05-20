// Data/MeuMVPContext.cs
using Microsoft.EntityFrameworkCore;
using MeuMVP.Models;

namespace MeuMVP.Data
{
    public class MeuMVPContext : DbContext
    {
        public MeuMVPContext(DbContextOptions<MeuMVPContext> options)
            : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
