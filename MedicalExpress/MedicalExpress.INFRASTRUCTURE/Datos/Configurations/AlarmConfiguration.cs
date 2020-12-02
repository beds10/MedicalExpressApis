using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class AlarmConfiguration : IEntityTypeConfiguration<Alarm>
    {
        public void Configure(EntityTypeBuilder<Alarm> builder)
        {
            builder.ToTable("Alarma");

            builder.HasKey(e => e.AlarmId)
                    .HasName("PK__Alarmas__F5D230D2BED709A5");

            builder.Property(e => e.AlarmId).HasColumnName("id_alarma");

            builder.Property(e => e.PharmacyAId).HasColumnName("id_ped");

            builder.Property(e => e.UserId).HasColumnName("id_users");

            builder.HasOne(d => d.PharmacyA)
                .WithMany(p => p.AlarmP)
                .HasForeignKey(d => d.PharmacyAId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Alarmas__id_ped__3B75D760");

            builder.HasOne(d => d.UserA)
                .WithMany(p => p.AlarmU)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Alarmas__id_user__3A81B327");

        }
    }
}
