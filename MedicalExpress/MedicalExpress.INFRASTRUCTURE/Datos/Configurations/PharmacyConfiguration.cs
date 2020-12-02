using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class PharmacyConfiguration : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            builder.ToTable("Farmacias");

            builder.HasKey(e => e.PharmaId)
                    .HasName("PK__Farmacia__6330CF4071F48D40");

            builder.Property(e => e.PharmaId).HasColumnName("id_farma");

            builder.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(300);

            builder.Property(e => e.Latitude).HasColumnName("latitud");

            builder.Property(e => e.Longitude).HasColumnName("longitud");

            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(300);
          
        }


    }
}
