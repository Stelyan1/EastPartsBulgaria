using EastParts.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EastParts.Data
{
    public class EastPartsDbContext : DbContext
    {
        public EastPartsDbContext()
        {

        }

        public EastPartsDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<CarBrand> CarBrands { get; set; } = null!;
        public virtual DbSet<CarBrandModels> CarModels { get; set; } = null!;
        public virtual DbSet<PartCategory> PartCategories { get; set; } = null!;
        public virtual DbSet<PartType> PartTypes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

    

