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

            builder.HasData(this.SeedPartCategories());
        }

        private List<PartCategory> SeedPartCategories()
        {
           List<PartCategory> partCategories = new List<PartCategory>()
           {
               new PartCategory 
               {
                    Id = new Guid("367C96B7-5930-4CE3-8BB0-658FD772C423"),
                    Name = "Brake System",
                    ImageUrl = "https://www.motortrend.com/uploads/f/31208710.jpg?w=768&width=768&q=75&format=webp"
               },

               new PartCategory
               {
                   Id= new Guid("368C96B7-5930-4CE3-8BB0-658FD772C423"),
                   Name = "Wheel Suspension",
                   ImageUrl = "https://media.istockphoto.com/id/1414449765/photo/wheel-structure-car-wheel-with-brake-isolated-on-a-white-background-3d-illustration.jpg?s=612x612&w=0&k=20&c=a8zRRvb0cbpPtjC7jMmqjVr5gKcNpx_ruPZJqPwGLYw="
               }
           };
           return partCategories;
        }
    }
}
