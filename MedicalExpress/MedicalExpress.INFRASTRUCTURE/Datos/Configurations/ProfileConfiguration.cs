using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("Perfil");


            builder.HasKey(e => e.ProfileId)
                  .HasName("PK__Perfil__1D1C8768DDCFEE88");

            builder.Property(e => e.ProfileId).HasColumnName("id_perfil");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(30);
        }

        }
}
