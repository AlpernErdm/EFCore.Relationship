using EFCore.Relationship.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Relationship.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UsersInformation { get; set; }
    }
}
