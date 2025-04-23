using EastParts.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastParts.Data.Configuration
{
    using static EastParts.Common.EntityValidationConstants.Product;
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(ProductNameMaxLength);

            builder.Property(p => p.ImageUrl)
                   .IsRequired();
                   
            builder.Property(p => p.Manufacturer)
                   .IsRequired()
                   .HasMaxLength(ProductManufacturerMaxLength);

            builder.Property(p => p.Description)
                   .HasMaxLength(ProductDescriptionMaxLength);

            builder.Property(p => p.Price)
                   .IsRequired()
                   .HasPrecision(18, 2);

            builder.Property(p => p.Quantity)
                   .IsRequired();

            builder.HasOne(p => p.CarBrand)
                   .WithMany(cb => cb.Products)
                   .HasForeignKey(p => p.CarBrandId);

            builder.HasOne(p => p.CarBrandModels)
                   .WithMany(cb => cb.Products)
                   .HasForeignKey(p => p.CarBrandModelsId);
        }
    }
}
