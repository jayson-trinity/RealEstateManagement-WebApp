using Microsoft.EntityFrameworkCore;
using TRINTY_ESTATES.Models;

namespace TRINTY_ESTATES.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<RentListingModel> listings { get; set; }

    }
}
