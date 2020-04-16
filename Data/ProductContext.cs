using System;
using Microsoft.EntityFrameworkCore;
using products;

namespace Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {

        }
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {

        }

        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<Cream> Creams { get; set; }
        public DbSet<MakeUp> MakeUp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Connection.ConnectionString).UseLazyLoadingProxies();
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
