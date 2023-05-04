using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Domain.Entities;using YouLearn.Domain.Entities;

namespace YouLearn.Infra.Persistence.EF.MAP;

public class MapCanal : IEntityTypeConfiguration<Canal>
{
    public void Configure(EntityTypeBuilder<Canal> builder)
    {
        builder.ToTable("Canal");
        builder.HasOne(x=>x.Usuario).WithMany().HasForeignKey("IdUsuario");
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Nome).HasMaxLength(50).IsRequired();
        builder.Property(x=> x.UrlLogo).HasMaxLength(255).IsRequired();
    }
}
