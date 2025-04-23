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
    }
}
