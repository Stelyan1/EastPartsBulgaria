using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastParts.Data.Models
{
    public class CarBrandModels
    {
        public CarBrandModels()
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Model Identification")]
        public Guid Id { get; set; }

        [Comment("Model Name")]
        public string Name { get; set; } = null!;

        [Comment("Model Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Brand to whom it belongs")]
        public Guid CarBrandId { get; set; }
        public virtual CarBrand CarBrand { get; set; } = null!;

        [Comment("Products belonging to the model")]
        public virtual ICollection<Product> Products { get; set; }
              = new HashSet<Product>();
    }
}
