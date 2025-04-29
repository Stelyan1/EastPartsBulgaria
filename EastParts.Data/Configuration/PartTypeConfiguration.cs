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

            builder.HasData(this.SeedPartTypes());
        }

        private List<PartType> SeedPartTypes()
        {
            List<PartType> partTypes = new List<PartType>()
            {
                new PartType                 {
                    Id = new Guid("420C96B7-5930-4CE3-8BB0-658FD772C423"),
                    Name = "Brake Pads",
                    ImageUrl = "https://mcprod.gsfcarparts.com/media/catalog/category/brake-pads_2.png",
                    PartCategoryId = new Guid("367C96B7-5930-4CE3-8BB0-658FD772C423")
                },

                new PartType
                {
                    Id = new Guid("421C19B3-6030-4CE3-8BB0-658FD772C423"),
                    Name = "Sport Springs",
                    ImageUrl = "https://www.h-r.com/wp-content/uploads/2022/11/HR-Tieferlegungsfedern-1.png",
                    PartCategoryId = new Guid("368C96B7-5930-4CE3-8BB0-658FD772C423")
                }
            };
            return partTypes;
        }
    }
}
