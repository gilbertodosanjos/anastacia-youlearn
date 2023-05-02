using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Doumain.Entities;

namespace YouLearn.Infra.Persistence.EF.MAP;

public class MapVideo : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder.ToTable("Video");

        builder.HasOne(x=>x.UsuarioSugeriu).WithMany().HasForeignKey("IdUsuario");
        builder.HasOne(x=>x.Canal).WithMany().HasForeignKey("IdCanal");
        builder.HasOne(x=>x.PlayList).WithMany().HasForeignKey("IdPlayList");

        //Propriedades
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Titulo).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Tags).HasMaxLength(100).IsRequired();
        builder.Property(x => x.OrdemNaPlayList);
        //builder.Property(x => x.UrlLogo).HasMaxLength(200).IsRequired();
        builder.Property(x => x.IdVideoYoutube).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Status).IsRequired();
    }
}
