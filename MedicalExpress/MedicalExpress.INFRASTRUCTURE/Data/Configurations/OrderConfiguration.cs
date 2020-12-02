using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Pedidos");

            builder.HasKey(e => e.OrderId)
                    .HasName("PK6")
                    .IsClustered(false);


            builder.Property(e => e.OrderId).HasColumnName("id_pedidos");

            builder.Property(e => e.Destination)
                .IsRequired()
                .HasColumnName("direccion")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Session_token)
        .IsRequired()
        .HasColumnName("session_token")
        .HasMaxLength(200)
        .IsUnicode(false);

            builder.Property(e => e.Total_compra)
            .HasColumnName("total_compra")
            .HasColumnType("decimal(18, 0)");

            builder.Property(e => e.StatusOId).HasColumnName("id_estatus");

            builder.Property(e => e.PharmOId).HasColumnName("id_farmacia");

            builder.Property(e => e.ProductOId).HasColumnName("id_productos");

            builder.Property(e => e.UserOId).HasColumnName("id_usuario");

            builder.HasOne(d => d.StatusO)
                .WithMany(p => p.OrderS)
                .HasForeignKey(d => d.StatusOId)
                .HasConstraintName("RefEstatus36");

            builder.HasOne(d => d.PharmacyO)
                .WithMany(p => p.OrderP)
                .HasForeignKey(d => d.PharmOId)
                .HasConstraintName("RefFarmacias42");

            builder.HasOne(d => d.ProductO)
                .WithMany(p => p.OrderPr)
                .HasForeignKey(d => d.ProductOId)
                .HasConstraintName("RefProductos43");

            builder.HasOne(d => d.UserO)
                .WithMany(p => p.OrderU)
                .HasForeignKey(d => d.UserOId)
                .HasConstraintName("RefUsuarios32");
        }

        }
}
