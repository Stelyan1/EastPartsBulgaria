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
        }
    }
}
