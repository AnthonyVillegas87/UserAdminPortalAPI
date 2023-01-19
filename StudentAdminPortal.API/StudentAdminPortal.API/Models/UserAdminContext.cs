using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudentAdminPortal.API.Models
{
    public class UserAdminContext : DbContext 
    {
        public UserAdminContext(DbContextOptions<UserAdminContext> options) : base(options) 
        {


        }

        public DbSet<User> User { get; set; }

    }
}
