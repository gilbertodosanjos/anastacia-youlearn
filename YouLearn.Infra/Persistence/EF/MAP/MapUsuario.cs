using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Doumain.Entities;
using YouLearn.Doumain.ValueObjects;

namespace YouLearn.Infra.Persistence.EF.MAP;

public class MapUsuario : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        //Tabela builder
        builder.ToTable("Usuario");

        //chave primária
        builder.HasKey(x=>x.Id);

        builder.Property(x=> x.Senha).HasMaxLength(36).IsRequired();

        //mapeando objetos de valor
        builder.OwnsOne<Nome>(x=>x.Nome,cb  => 
        {
            cb.Property(x=>x.PrimeiroNome).HasMaxLength(50).HasColumnName("PrimeiroNome").IsRequired();
            cb.Property(x=>x.UltimoNome).HasMaxLength(50).HasColumnName("UltimoNome").IsRequired();
        ;});

        builder.OwnsOne<Email>(x=>x.Email,cb  => 
        {
            cb.Property(x=>x.Endereco).HasMaxLength(200).HasColumnName("Email").IsRequired();
        ;});

    }
}
