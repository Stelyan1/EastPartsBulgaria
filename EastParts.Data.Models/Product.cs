using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastParts.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Product Identification")]
        public Guid Id { get; set; }

        [Comment("Product Name")]
        public string Name { get; set; } = null!;

        [Comment("Image of the product")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Product manufacturer")]
        public string Manufacturer { get; set; } = null!;

        [Comment("Product description")]
        public string Description { get; set; }

        [Comment("Product price")]
        public decimal Price { get; set; }

        [Comment("Product can be used for certain model")]
        public Guid CarBrandModelsId { get; set; }
        public virtual CarBrandModels CarBrandModels { get; set; } = null!;
    }
}
