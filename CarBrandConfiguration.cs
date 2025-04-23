using System;


public class CarBrandConfiguration : IEntityTypeConfiguration<CarBrand>
{
	public void Configure(EntityTypeBuilder<CarBrand> builder)
	{
		builder.HasKey(cb => cb.Id);

		builder.HasProperty(cb => cb.Name)
			   .IsRequired()
               .HasMaxLength(100);

		builder.HasProperty(cb => cb.ImageUrl)
			   .IsRequired();

    }
}
