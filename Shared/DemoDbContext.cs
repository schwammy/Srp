using Microsoft.EntityFrameworkCore;

namespace Shared
{
    public class DemoDbContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
    }
}
