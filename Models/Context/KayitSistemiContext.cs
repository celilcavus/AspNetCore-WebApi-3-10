using CelilCavus.OgrenciKayitSistemi.Configuration;
using CelilCavus.OgrenciKayitSistemi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.OgrenciKayitSistemi.Context
{
    public class KayitSistemiContext:DbContext
    {
        public DbSet<Dersler> Derslers { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ogrenci_kayit_sistemi;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DerslerConfiguration());
            modelBuilder.ApplyConfiguration(new OgrenciConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}