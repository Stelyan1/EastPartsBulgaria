using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastParts.Data.Models
{
    public class PartCategory
    {
        public PartCategory()
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Category Identification")]
        public Guid Id { get; set; }

        [Comment("Category Name")]
        public string Name { get; set; } = null!;

        [Comment("Category Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Category has many part types")]
        public virtual ICollection<PartType> PartTypes { get; set; } 
            = new HashSet<PartType>();
    }
}
