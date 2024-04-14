using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace PFE_CHU.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Devision> Devisions { get; set; }
        public DbSet<Hopitaux> Hopitaux { get; set; }
        public Context(DbContextOptions opt) : base(opt) { }
        
    }
}
