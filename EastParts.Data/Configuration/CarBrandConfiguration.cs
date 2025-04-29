using EastParts.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

using static EastParts.Common.EntityValidationConstants.CarBrand;
public class CarBrandConfiguration : IEntityTypeConfiguration<CarBrand>
{
	public void Configure(EntityTypeBuilder<CarBrand> builder)
	{
		builder.HasKey(cb => cb.Id);

		builder.Property(cb => cb.Name)
			   .IsRequired()
               .HasMaxLength(CarBrandNameMaxLength);

		builder.Property(cb => cb.ImageUrl)
			   .IsRequired();

		builder.HasData(this.SeedCarBrands());
    }

	private List<CarBrand> SeedCarBrands()
	{
		List<CarBrand> carBrands = new List<CarBrand>()
		{
			  new CarBrand
              {
				Id = new Guid("148C46B7-5930-4CE3-8BB0-658FD772C423"),
                Name = "BMW",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/BMW.svg"
              },

			  new CarBrand
			  {
                  Id = new Guid("149C57B8-5930-4CE3-8BB0-658FD772C423"),
                  Name = "Mercedes-Benz",
                  ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Mercedes-Logo.svg/1200px-Mercedes-Logo.svg.png"
              }
        };
		return carBrands;
    }
}
