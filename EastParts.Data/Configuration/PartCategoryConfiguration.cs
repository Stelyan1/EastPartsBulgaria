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
    using static EastParts.Common.EntityValidationConstants.PartCategory;
    public class PartCategoryConfiguration : IEntityTypeConfiguration<PartCategory>
    {
        public void Configure(EntityTypeBuilder<PartCategory> builder)
        {
            builder.HasKey(pc => pc.Id);

            builder.Property(pc => pc.Name)
                .IsRequired()
                .HasMaxLength(PartCategoryNameMaxLength);

            builder.Property(pc => pc.ImageUrl)
                   .IsRequired();

            builder.HasOne(pc => pc.CarBrandModels)
                   .WithMany(cbm => cbm.PartCategories)
                   .HasForeignKey(pc => pc.CarBrandModelsId);
        }
    }
}
