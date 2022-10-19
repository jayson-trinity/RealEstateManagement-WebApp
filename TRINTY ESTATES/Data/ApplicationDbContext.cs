using Microsoft.EntityFrameworkCore;

namespace TRINTY_ESTATES.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}
