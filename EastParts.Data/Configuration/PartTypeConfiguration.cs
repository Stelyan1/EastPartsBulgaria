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
    using static EastParts.Common.EntityValidationConstants.PartType;
    public class PartTypeConfiguration : IEntityTypeConfiguration<PartType>
    {
        public void Configure(EntityTypeBuilder<PartType> builder)
        {
            builder.HasKey(pt => pt.Id);

            builder.Property(pt => pt.Name)
                .IsRequired()
                .HasMaxLength(PartTypeNameMaxLength);

            builder.Property(pt => pt.ImageUrl)
                   .IsRequired();

            builder.HasOne(pt => pt.PartCategory)
                   .WithMany(pc => pc.PartTypes)
                   .HasForeignKey(pt => pt.PartCategoryId);
        }
    }
}
