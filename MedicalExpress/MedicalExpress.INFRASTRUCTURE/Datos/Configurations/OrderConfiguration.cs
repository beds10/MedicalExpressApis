using MedicalExpress.CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalExpress.INFRASTRUCTURE.Datos.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Pedidos");

            builder.HasKey(e => e.OrderId)
                    .HasName("PK__Pedidos__6FF014892775E97F");

            builder.Property(e => e.OrderId).HasColumnName("id_pedido");

            builder.Property(e => e.Cost).HasColumnName("costo");

            builder.Property(e => e.Destination)
                .IsRequired()
                .HasColumnName("destino")
                .HasMaxLength(300);

            builder.Property(e => e.PharmOId).HasColumnName("id_farm");

            builder.Property(e => e.UserOId).HasColumnName("id_user");

            builder.Property(e => e.Latitude).HasColumnName("latitud");

            builder.Property(e => e.Longitude).HasColumnName("longitud");

            builder.HasOne(d => d.PharmacyO)
                .WithMany(p => p.OrderP)
                .HasForeignKey(d => d.PharmOId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pedidos__id_farm__37A5467C");

            builder.HasOne(d => d.UserO)
                .WithMany(p => p.OrderU)
                .HasForeignKey(d => d.UserOId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pedidos__id_user__36B12243");
        }

        }
}
