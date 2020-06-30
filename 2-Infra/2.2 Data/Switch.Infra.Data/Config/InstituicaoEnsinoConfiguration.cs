using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class InstituicaoEnsinoConfiguration : IEntityTypeConfiguration<InstituicaoEnsino>
    {
        public void Configure(EntityTypeBuilder<InstituicaoEnsino> builder)
        {
            builder.HasKey(i => i.Id);
           
          
        }
    }
}
