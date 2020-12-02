using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class PhotoUserConfiguration : IEntityTypeConfiguration<PhotoUser>
    {
        public void Configure(EntityTypeBuilder<PhotoUser> builder)
        {
            builder.ToTable("Foto_Usuario");
            builder.HasKey(e => e.PhotoId)
                 .HasName("PK7")
                 .IsClustered(false);

            builder.ToTable("Foto_Usuario");

            builder.HasIndex(e => e.UserIdP)
                .HasName("Ref115");

            builder.Property(e => e.PhotoId).HasColumnName("id_foto");

            builder.Property(e => e.UserIdP).HasColumnName("id_usuario");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nom_img")
                .HasMaxLength(230);

            builder.HasOne(d => d.UserPhoto)
    .WithMany(p => p.PhotoUserU)
    .HasForeignKey(d => d.UserIdP)
    .HasConstraintName("RefUsuarios45");



        }
    }
}
