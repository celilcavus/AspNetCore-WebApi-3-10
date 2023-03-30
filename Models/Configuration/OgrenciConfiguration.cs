using CelilCavus.OgrenciKayitSistemi.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.OgrenciKayitSistemi.Configuration
{
    public class OgrenciConfiguration : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasKey(x=>x.id);
            builder.Property(x=>x.id).UseIdentityColumn();

            builder.Property(x=>x.ad)
            .HasMaxLength(20)
            .HasDefaultValue("Öğrenci Adi Tanimsiz");
            
            builder.Property(x=>x.soyad)
            .HasMaxLength(20)
            .HasDefaultValue("Öğrenci Soyadi Tanimsiz.");

            builder.Property(x=>x.cinsiyet)
            .HasMaxLength(10)
            .HasDefaultValue("Öğrenci Cinsiyet Tanimsiz");

            builder.Property(x=>x.bolum)
            .HasMaxLength(10)
            .HasDefaultValue("Öğrenci Bölüm Tanimsiz");
        
            builder.Property(x=>x.sinif)
            .HasDefaultValue(null);
        }
    }
}