using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(e => e.CategoryId)
                      .HasName("PK__Categori__CD54BC5AE21CF3CA");

            builder.Property(e => e.CategoryId).HasColumnName("id_categoria");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(300);
        }
    }
}
