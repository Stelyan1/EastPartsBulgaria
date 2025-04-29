using Microsoft.EntityFrameworkCore;

namespace EastParts.Data.Models
{
    public class CarBrand
    {
        public CarBrand() 
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Brand Identification")]
        public Guid Id { get; set; }

        [Comment("Brand Name")]
        public string Name { get; set; } = null!;

        [Comment("Brand Logo")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Models belonging to the brand")]
        public virtual ICollection<CarBrandModels> CarBrandModels { get; set; } 
            = new HashSet<CarBrandModels>();
    }
}
