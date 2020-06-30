using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Descricao);

            builder.HasData(

                new StatusRelacionamento() { Id = 1, Descricao = "NaoDefinido" },
                new StatusRelacionamento() { Id = 2, Descricao = "Solteiro" },
                new StatusRelacionamento() { Id = 3, Descricao = "Casado" },
                new StatusRelacionamento() { Id = 4, Descricao = "EmRelacionamentoSerio" }
                );

        }
    }
}
