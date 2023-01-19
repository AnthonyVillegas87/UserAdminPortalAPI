using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UserAdminPortal.API.Models
{
    public class UserAdminContext : DbContext 
    {
        public UserAdminContext(DbContextOptions<UserAdminContext> options) : base(options) 
        {


        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }
                        

    }
}
