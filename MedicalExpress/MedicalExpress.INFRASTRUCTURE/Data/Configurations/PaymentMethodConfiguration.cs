using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<MethodPayment>
    {
        public void Configure(EntityTypeBuilder<MethodPayment> builder)
        {
            builder.ToTable("Modo_pago");

            builder.HasKey(e => e.PaymentId)
                   .HasName("PK10");

            builder.Property(e => e.PaymentId).HasColumnName("id_pago");

            builder.Property(e => e.MethodName)
                .HasColumnName("nombre_pago")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
