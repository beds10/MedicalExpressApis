using System;
using MedicalExpress.CORE.Entity;
using MedicalExpress.INFRASTRUCTURE.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MedicalExpress.INFRASTRUCTURE.Data 
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

        public virtual DbSet<Alarm> Alarma { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Detailord> Detailords { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Pharmacy> Pharmacys { get; set; }
        public virtual DbSet<PhotoUser> PhotosUser { get; set; }
        public virtual DbSet<MethodPayment> MethodPayments { get; set; }
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
            modelBuilder.ApplyConfiguration(new DetailsordConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
        }

    }
}
