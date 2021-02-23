using eCommerce.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions options) : base(options) { }


        public DbSet<User> Users { get; set; }
    }
}
