using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.DataPublicacao)
                .IsRequired();

            entity.Property(p => p.Texto)
                  .IsRequired()
                  .HasMaxLength(400);

            entity.HasOne(p => p.Usuario)
                  .WithMany(u => u.Postagens);

        }
    }
}
