using Microsoft.EntityFrameworkCore;
using YouLearn.Doumain.Entities;
using YouLearn.Shared;

namespace YouLearn.Infra.Persistence.EF
{
    public class YouLeranContext : DbContext 
    {
        public DbSet<Canal>?  Canais { get;  set; }

        //public DbSet <Favorito>? Favoritos { get; set; }

        public DbSet <PlayList>? PlayLists { get; set; }

        public DbSet<Usuario>? Usuarios { get; set; }

        public DbSet <Video>? Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}


