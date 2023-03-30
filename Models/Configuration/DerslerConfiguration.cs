using CelilCavus.OgrenciKayitSistemi.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.OgrenciKayitSistemi.Configuration
{
    public class DerslerConfiguration : IEntityTypeConfiguration<Dersler>
    {
        public void Configure(EntityTypeBuilder<Dersler> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();

            builder.Property(x => x.ders_adi)
            .HasMaxLength(40)
            .HasDefaultValue("Ders Adi Tanimsiz");


            builder.Property(x => x.ders_donemi)
            .HasMaxLength(10)
            .HasDefaultValue("Ders Dönemi Tanimsiz");

            builder.Property(x => x.ders_hocasi)
            .HasMaxLength(40)
            .HasDefaultValue("Ders Hocasi Tanimsiz");

            builder.Property(x => x.ders_kodu)
            .HasMaxLength(5)
            .HasDefaultValue("00000");
        }
    }
}