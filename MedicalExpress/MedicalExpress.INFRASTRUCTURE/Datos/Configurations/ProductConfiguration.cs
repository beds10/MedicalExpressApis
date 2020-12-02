using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Productos");

            builder.HasKey(e => e.ProductoId)
                  .HasName("PK__Producto__FF341C0D31EE4EA4");

            builder.Property(e => e.ProductoId).HasColumnName("id_producto");

            builder.Property(e => e.Content)
                .IsRequired()
                .HasColumnName("contenido")
                .HasMaxLength(300);

            builder.Property(e => e.CatIdP).HasColumnName("id_cat");

            builder.Property(e => e.PharIdP).HasColumnName("id_far");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(300);

            builder.Property(e => e.Stock)
                .IsRequired()
                .HasColumnName("stock")
                .HasMaxLength(300);

            builder.HasOne(d => d.CategoryP)
                .WithMany(p => p.ProductC)
                .HasForeignKey(d => d.CatIdP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__id_ca__33D4B598");

            builder.HasOne(d => d.PharmacyP)
                .WithMany(p => p.ProductP)
                .HasForeignKey(d => d.PharIdP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Productos__id_fa__32E0915F");
        }



        }
}
