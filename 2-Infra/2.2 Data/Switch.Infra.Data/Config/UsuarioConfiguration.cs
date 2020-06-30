using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Nome).HasMaxLength(400).IsRequired();
            entity.Property(x => x.Senha).HasMaxLength(30).IsRequired();
            entity.Property(x => x.Sexo).IsRequired();
            entity.Property(x => x.SobreNome).HasMaxLength(400).IsRequired();
            entity.Property(x => x.UrlFoto).HasMaxLength(400).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(400).IsRequired();
            entity.Property(x => x.DataNascimento).IsRequired();
            entity.HasOne(u => u.Identificacao)
                .WithOne(i => i.Usuario)
                .HasForeignKey<Identificacao>(i => i.UsuarioId);
            entity.HasMany(p => p.Postagens).WithOne(u => u.Usuario);
            entity.HasMany(u => u.Comentarios).WithOne(c => c.Usuario);
            entity.HasMany(u => u.Amigos).WithOne(a => a.UsuarioAmigo);

        }
    }
}
