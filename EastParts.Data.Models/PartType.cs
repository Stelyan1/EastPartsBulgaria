using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastParts.Data.Models
{
    public class PartType
    {
        public PartType()
        {
            this.Id = Guid.NewGuid();
        }

        [Comment("Part Type Identification")]
        public Guid Id { get; set; }

        [Comment("Part Type Name")]
        public string Name { get; set; } = null!;

        [Comment("Part Type Image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Part Type belongs to a certain category")]
        public Guid PartCategoryId { get; set; }
        public virtual PartCategory PartCategory { get; set; } = null!;
    }
}
