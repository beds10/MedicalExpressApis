using System;
using MedicalExpress.CORE.Entidades;
using MedicalExpress.INFRASTRUCTURE.Datos.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MedicalExpress.INFRASTRUCTURE.Datos
{
    public partial class MedicalExpressDBContext : DbContext
    {
        public MedicalExpressDBContext()
        {
        }

        public MedicalExpressDBContext(DbContextOptions<MedicalExpressDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Pharmacy> Pharmacys { get; set; }
        public virtual DbSet<PhotoUser> PhotosUser { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new PharmacyConfiguration());
            modelBuilder.ApplyConfiguration(new AlarmConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PhotoUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }


    }
}
