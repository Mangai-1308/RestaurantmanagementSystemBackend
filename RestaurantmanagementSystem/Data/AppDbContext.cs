using Microsoft.EntityFrameworkCore;
using RestaurantmanagementSystem.Modals;

namespace RestaurantmanagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurant { get; set; }
    }
}
