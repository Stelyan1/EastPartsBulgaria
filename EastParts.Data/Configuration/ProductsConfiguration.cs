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

            builder.HasOne(p => p.CarBrandModels)
                   .WithMany(cb => cb.Products)
                   .HasForeignKey(p => p.CarBrandModelsId);

            builder.HasData(this.SeedProducts());
        }

        private List<Product> SeedProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = new Guid("520C19B6-7030-4CE3-8BB0-658FD772C423"),
                    Name = "BREMBO PRIME LINE pads",
                    ImageUrl = "https://www.autopower.bg/images/%D0%BD%D0%B0%D0%BA%D0%BB%D0%B0%D0%B4%D0%BA%D0%B8-BREMBO-PRIME-LINE-P06088-BMW-3-Sedan-F30-F35-F80-340-i-imagetabig-845520901720541-BREMBO.jpg",
                    Manufacturer = "Brembo",
                    Description = "BREMBO PRIME LINE pads for BMW 3 Series F30/F35/F80 340i",
                    Price = 243.00m,
                    CarBrandModelsId = new Guid("258C46B7-5930-4CE3-8BB0-658FD772C423")
                },

                new Product
                {
                   Id= new Guid("521C29B6-7030-4CE3-8BB0-658FD772C423"),
                   Name = "BILSTEIN B3 OE Replacement",
                   ImageUrl = "https://www.autopower.bg/images/%D0%BF%D1%80%D1%83%D0%B6%D0%B8%D0%BD%D0%B0-BILSTEIN-B3-OE-Replacement-36-292141-Mercedes-C-class-Saloon-w204-C-63-AMG-204.077-imagetabig-845520896800921-BILSTEIN.jpg",
                   Manufacturer = "Bilstein",
                   Description = "BILSTEIN B3 OE Replacement for Mercedes C-Class W204 C-63 AMG",
                   Price = 135.00m,
                   CarBrandModelsId = new Guid("259C46B7-5930-4CE3-8BB0-658FD772C424")
                }
            };
            return products;
        }
    }
}
