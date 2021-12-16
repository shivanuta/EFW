using EFW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW
{
    public class EntityDbContext : DbContext
    {
        public DbSet<SaleItem> SaleItems { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleItem>();
            modelBuilder.Entity<Product>();

            base.OnModelCreating(modelBuilder);
        }

        public EntityDbContext(DbContextOptions<EntityDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
