using Microsoft.EntityFrameworkCore;

namespace UserDataMicroserviceAPI.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
    }
}