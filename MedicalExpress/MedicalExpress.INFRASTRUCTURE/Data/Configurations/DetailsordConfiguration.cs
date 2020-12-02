using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class DetailsordConfiguration : IEntityTypeConfiguration<Detailord>
    {

        public void Configure(EntityTypeBuilder<Detailord> builder)
        {
            builder.ToTable("Detalle_Pedido");

            builder.HasKey(e => e.DetailId)
                    .HasName("PK9")
                    .IsClustered(false);

            builder.Property(e => e.DetailId).HasColumnName("id_detalle");

            builder.Property(e => e.quantity).HasColumnName("cantidad");

            builder.Property(e => e.PaymentMethodDId).HasColumnName("id_pago");

            builder.Property(e => e.OrderDId).HasColumnName("id_pedidos");

            builder.Property(e => e.ProductDId).HasColumnName("id_productos");

            builder.Property(e => e.totalprice)
                .HasColumnName("precio_total")
                .HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.MethodD)
                .WithMany(p => p.DetailOrdM)
                .HasForeignKey(d => d.PaymentMethodDId)
                .HasConstraintName("RefModo_pago41");

            builder.HasOne(d => d.OrderD)
                .WithMany(p => p.DetailO)
                .HasForeignKey(d => d.OrderDId)
                .HasConstraintName("RefPedidos39");

            builder.HasOne(d => d.ProductD)
                .WithMany(p => p.DetailsPr)
                .HasForeignKey(d => d.ProductDId)
                .HasConstraintName("RefProductos44");
        }





    }

}

