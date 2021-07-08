using Logitech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Data
{
    public class LogitechContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public LogitechContext()
        {
        }

        public LogitechContext(DbContextOptions<LogitechContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("LogitechContext");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable(name: "Categorys");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable(name: "Products");
            });

            modelBuilder.Entity<ProductRating>(entity =>
            {
                entity.ToTable(name: "ProductRatings");
            }); 
            
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable(name: "Accounts");
            });
        }
    }
}


