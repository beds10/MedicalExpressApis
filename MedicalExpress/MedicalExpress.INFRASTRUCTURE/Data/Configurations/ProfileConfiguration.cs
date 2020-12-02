using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("Perfil");


            builder.HasKey(e => e.ProfileId)
                    .HasName("PK3")
                    .IsClustered(false);

            builder.Property(e => e.ProfileId).HasColumnName("id_perfil");

            builder.Property(e => e.Name)
                .HasColumnName("nombre")
                .HasMaxLength(30);
        }

        }
}
