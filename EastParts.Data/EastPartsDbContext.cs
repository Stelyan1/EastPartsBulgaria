using Microsoft.EntityFrameworkCore;

namespace EastParts.Data
{
    public class EastPartsDbContext : DbContext
    {
        public EastPartsDbContext(DbContextOptions options)
            : base(options)
        {

        }

    }
}

    

