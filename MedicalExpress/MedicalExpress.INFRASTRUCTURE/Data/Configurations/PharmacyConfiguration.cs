using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class PharmacyConfiguration : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            builder.ToTable("Farmacias");

            builder.HasKey(e => e.PharmaId)
                   .HasName("PK4")
                   .IsClustered(false);

            builder.Property(e => e.PharmaId).HasColumnName("id_farmacia");

            builder.Property(e => e.Adress)
                .IsRequired()
                .HasColumnName("direccion")
                .HasMaxLength(100);

            builder.Property(e => e.StatusPId).HasColumnName("id_estatus");

            builder.Property(e => e.Latitude).HasColumnName("latitud");

            builder.Property(e => e.Longitude).HasColumnName("longitud");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(70);

            builder.HasOne(d => d.StatusP)
                .WithMany(p => p.PharmacyS)
                .HasForeignKey(d => d.StatusPId)
                .HasConstraintName("RefEstatus35");

        }


    }
}
