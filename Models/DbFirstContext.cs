using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
    public partial class DbFirstContext : DbContext
    {
        public DbFirstContext()
        {
        }

        public DbFirstContext(DbContextOptions<DbFirstContext> options)
            : base(options)
        {
        }
    }
}
