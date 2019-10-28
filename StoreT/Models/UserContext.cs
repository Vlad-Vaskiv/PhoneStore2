using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreT.Models
{
    public class UserContext : IdentityDbContext<User, UserRole, string>
    {      
        //public DbSet<User> Users { get; set; }

        public DbSet<FirmPhones> Firms { get; set; }
        public DbSet<ModelPhone> ModelPhones { get; set; }
        public DbSet<Charachteristic> Charachteristics { get; set; }
        public DbSet<ImageModel> ImageModels { get; set; }
        public DbSet<UserCabinet> UserCabinets { get; set; }
        public DbSet<QuantityPhone> QuantityPhones { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
             // modelBuilder.ApplyConfiguration(new ImageUserConfiguration());

            // modelBuilder.Entity<ImageUser>().HasKey(u => u.Id);
            modelBuilder.ApplyConfiguration(new FirmConfiguration());
            modelBuilder.ApplyConfiguration(new CharachConfiguration());
            modelBuilder.ApplyConfiguration(new ImageModelConfiguration());
            modelBuilder.ApplyConfiguration(new UserCabinetConfiguration());
            modelBuilder.ApplyConfiguration(new QuantityPhoneConfiguration());
            modelBuilder.ApplyConfiguration(new ModelPhoneConfiguration());
        }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           // builder.HasKey(u => u.Id);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(20);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(20);
        }
    }

    public class FirmConfiguration : IEntityTypeConfiguration<FirmPhones>
    {
        public void Configure(EntityTypeBuilder<FirmPhones> builder)
        {
            builder.HasKey(u => u.Id);
            
        }
    }

    public class CharachConfiguration : IEntityTypeConfiguration<Charachteristic>
    {
        public void Configure(EntityTypeBuilder<Charachteristic> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(ui => ui.ModelPhone)
                   .WithOne(t => t.Charachteristic)
                   .HasForeignKey<Charachteristic>(ui => ui.ModelId);

        }
    }

    public class ImageModelConfiguration : IEntityTypeConfiguration<ImageModel>
    {
        public void Configure(EntityTypeBuilder<ImageModel> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(ui => ui.ModelPhone)
                   .WithOne(t => t.ImageModel)
                   .HasForeignKey<ImageModel>(ui => ui.ImageModelId);
        }
    }

    public class UserCabinetConfiguration : IEntityTypeConfiguration<UserCabinet>
    {
        public void Configure(EntityTypeBuilder<UserCabinet> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(ui => ui.User)
                   .WithOne(t => t.UserCabinet)
                   .HasForeignKey<UserCabinet>(ui => ui.UserId);
        }
    }

    public class QuantityPhoneConfiguration : IEntityTypeConfiguration<QuantityPhone>
    {
        public void Configure(EntityTypeBuilder<QuantityPhone> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(ui => ui.ModelPhone)
                   .WithOne(t => t.QuantityPhone)
                   .HasForeignKey<QuantityPhone>(ui => ui.QuantId);
        }
    }

    public class ModelPhoneConfiguration : IEntityTypeConfiguration<ModelPhone>
    {
        public void Configure(EntityTypeBuilder<ModelPhone> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(ui => ui.FirmPhones)
                   .WithOne(t => t.ModelPhone)
                   .HasForeignKey<ModelPhone>(ui => ui.FirmId);


        }

    }
    /*
        public class ImageUserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.HasKey(u => u.Id);
                builder.HasOne(ui => ui.User)
                       .WithOne(t => t.ImageUsers)
                       .HasForeignKey(ui => ui.idUser);


            }

        }
      */
}
