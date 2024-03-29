using Microsoft.EntityFrameworkCore;

namespace PFE_CHU.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public Context(DbContextOptions opt) : base(opt) { }
    }
}
