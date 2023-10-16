using Microsoft.EntityFrameworkCore;
using teste_pratico_iel.Models;


namespace teste_pratico_iel.Context
{
    public class IELContext : DbContext
    {

        public IELContext(DbContextOptions<IELContext> options) : base(options)
        {

        }

        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
