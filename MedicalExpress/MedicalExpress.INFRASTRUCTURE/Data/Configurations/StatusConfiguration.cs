using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Estatus");

            builder.HasKey(e => e.StatusId)
                    .HasName("PK11")
                    .IsClustered(false);

            builder.Property(e => e.StatusId).HasColumnName("id_estatus");

            builder.Property(e => e.StatusName)
                .HasColumnName("nombre_status")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
