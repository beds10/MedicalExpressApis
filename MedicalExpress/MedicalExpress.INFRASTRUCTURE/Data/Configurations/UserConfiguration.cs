using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.UserId)
                   .HasName("PK1")
                   .IsClustered(false);

            builder.Property(e => e.UserId).HasColumnName("id_usuario");

            builder.Property(e => e.NumberCellphone)
                .IsRequired()
                .HasColumnName("celular")
                .HasMaxLength(12);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("correo")
                .HasMaxLength(100);

            builder.Property(e => e.Direction)
                .HasColumnName("direccion")
                .HasMaxLength(200);


            builder.Property(e => e.ProfileId).HasColumnName("id_perfil");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(100);

            builder.Property(e => e.Pass)
                .IsRequired()
                .HasColumnName("pass")
                .HasMaxLength(20);

              builder.HasOne(d => d.IdPerfilNavigation)
                .WithMany(p => p.UserProfile)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("RefPerfil29");
        }


    }
}
