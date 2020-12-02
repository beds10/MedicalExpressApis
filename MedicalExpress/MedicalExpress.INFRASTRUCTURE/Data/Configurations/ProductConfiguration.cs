using MedicalExpress.CORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Productos");

            builder.HasKey(e => e.ProductoId)
                    .HasName("PK2")
                    .IsClustered(false);

            builder.Property(e => e.ProductoId).HasColumnName("id_productos");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("descripcion")
                .HasMaxLength(500);

            builder.Property(e => e.CategoryPrId).HasColumnName("id_categorias");

            builder.Property(e => e.StatusPrId).HasColumnName("id_estatus");

            builder.Property(e => e.PharmacyPrId).HasColumnName("id_farmacia");

            builder.Property(e => e.ProductImage)
                .HasColumnName("imagen_producto")
                .HasMaxLength(1000);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(300);

            builder.Property(e => e.Product_stripe)
                .IsRequired()
                .HasColumnName("product_stripe")
                .HasMaxLength(200);

            builder.Property(e => e.Price_stripe)
                .IsRequired()
                .HasColumnName("price_stripe")
                .HasMaxLength(200);

            builder.Property(e => e.UPrice)
                .HasColumnName("precio")
                .HasColumnType("decimal(18, 0)");

            builder.Property(e => e.Stock).HasColumnName("stock");

            builder.HasOne(d => d.CategoryPr)
                .WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoryPrId)
                .HasConstraintName("RefCategorias38");

            builder.HasOne(d => d.StatusPr)
                .WithMany(p => p.ProductS)
                .HasForeignKey(d => d.StatusPrId)
                .HasConstraintName("RefEstatus34");

            builder.HasOne(d => d.PharmacyPr)
              .WithMany(p => p.ProductPh)
              .HasForeignKey(d => d.PharmacyPrId)
              .HasConstraintName("RefFarmacias37");
        }



        }
}
