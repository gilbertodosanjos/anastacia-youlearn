using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Doumain.Entities;

namespace YouLearn.Infra.Persistence.EF.MAP
{
    public class MapPlayList : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.ToTable("PlayList");
            builder.HasOne(x=>x.Usuario).WithMany().HasForeignKey("IdUsuario");

            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Nome).HasMaxLength(50).IsRequired();
        }
    }
}