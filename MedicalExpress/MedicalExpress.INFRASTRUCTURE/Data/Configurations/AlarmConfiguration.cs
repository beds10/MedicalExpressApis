using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class AlarmConfiguration : IEntityTypeConfiguration<Alarm>
    {
        public void Configure(EntityTypeBuilder<Alarm> builder)
        {
            builder.ToTable("Alarma");

            builder.HasKey(e => e.AlarmId)
                     .HasName("PK8")
                     .IsClustered(false);

            builder.Property(e => e.AlarmId).HasColumnName("id_alarma");

            builder.Property(e => e.OrderId).HasColumnName("id_pedidos");

            builder.Property(e => e.UserId).HasColumnName("id_usuario");

            builder.HasOne(d => d.OrderA)
                .WithMany(p => p.AlarmO)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("RefPedidos40");

            builder.HasOne(d => d.UserA)
                .WithMany(p => p.AlarmU)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("RefUsuarios33");

        }
    }
}
