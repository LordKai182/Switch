using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class UsuaruiGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            builder.HasKey(g => new { g.UsuarioId, g.GrupoId });

            builder.Property(g => g.DataCriacao)
                .IsRequired();

            builder.Property(g => g.EhAdministrador)
                .IsRequired();
        }
    }
}
