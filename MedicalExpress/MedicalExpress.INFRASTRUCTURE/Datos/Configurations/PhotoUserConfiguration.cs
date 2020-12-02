using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class PhotoUserConfiguration : IEntityTypeConfiguration<PhotoUser>
    {
        public void Configure(EntityTypeBuilder<PhotoUser> builder)
        {
            builder.ToTable("Foto_Usuario");
            builder.HasKey(e => e.PhotoId)
                     .HasName("PK__FotoUser__620EA3A5A1BA1183");

            builder.Property(e => e.PhotoId).HasColumnName("id_foto");

            builder.Property(e => e.UserIdP).HasColumnName("id_user");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(300);

            builder.HasOne(d => d.UserP)
                .WithMany(p => p.PhotouserU)
                .HasForeignKey(d => d.UserIdP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FotoUser__id_use__286302EC");
        }
    }
}
