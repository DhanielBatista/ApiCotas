using Microsoft.EntityFrameworkCore;
using TrinusApi.Models;

namespace TrinusApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {


        }

        public DbSet<Cotista> Cotistas { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Operacao>()
                .HasOne(operacao => operacao.Cotista)
                .WithMany(cotista => cotista.Operacoes)
                .HasForeignKey(operacao => operacao.CotistaId);
        }
    }
}
