using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.UserId)
                .HasName("PK__Usuarios__6AE80FBB21F6E6DE");

            builder.Property(e => e.UserId).HasColumnName("id_usu");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("correo")
                .HasMaxLength(100);

            builder.Property(e => e.PerfilIdU).HasColumnName("id_perf");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(100);

            builder.Property(e => e.Pass)
                .IsRequired()
                .HasColumnName("pass")
                .HasMaxLength(50);

            builder.HasOne(d => d.ProfileU)
                .WithMany(p => p.UserP)
                .HasForeignKey(d => d.PerfilIdU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuarios__id_per__25869641");
        }


    }
}
