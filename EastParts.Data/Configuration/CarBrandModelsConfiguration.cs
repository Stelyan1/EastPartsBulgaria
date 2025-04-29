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
    using static EastParts.Common.EntityValidationConstants.CarBrandModels;
    public class CarBrandModelsConfiguration : IEntityTypeConfiguration<CarBrandModels>
    {
        public void Configure(EntityTypeBuilder<CarBrandModels> builder)
        {
            builder.HasKey(cbm => cbm.Id);

            builder.Property(cbm => cbm.Name)
                   .IsRequired()
                   .HasMaxLength(CarBrandModelsNameMaxLength);

            builder.Property(cbm => cbm.ImageUrl)
                   .IsRequired();

            builder.HasOne(cbm => cbm.CarBrand)
                   .WithMany(cb => cb.CarBrandModels)
                   .HasForeignKey(cbm => cbm.CarBrandId);

            builder.HasData(this.SeedCarBrandModels());
        }

        private List<CarBrandModels> SeedCarBrandModels()
        {
            List<CarBrandModels> carBrandModels = new List<CarBrandModels>()
            {
                new CarBrandModels()
                {
                    Id = new Guid("258C46B7-5930-4CE3-8BB0-658FD772C423"),
                    Name = "F30 340i",
                    ImageUrl = "https://curvaconcepts.com/wp-content/uploads/silver-f30-bmw-340i-c300-4.jpg",
                    CarBrandId = new Guid("148C46B7-5930-4CE3-8BB0-658FD772C423")
                },

                new CarBrandModels()
                {
                    Id = new Guid("259C46B7-5930-4CE3-8BB0-658FD772C424"),
                    Name = "C-63",
                    ImageUrl = "https://www.litchfieldmotors.com/wp-content/uploads/w204_top_p-1700x850.jpg",
                    CarBrandId = new Guid("149C57B8-5930-4CE3-8BB0-658FD772C423")
                }
            };
            return carBrandModels;
        }
    }
}
