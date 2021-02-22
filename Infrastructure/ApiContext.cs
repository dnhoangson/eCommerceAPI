using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class ApiContext : DbContext
    {
        protected readonly IConfiguration _config;

        public ApiContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_config.GetConnectionString("DataServer"));
        }

        public DbSet<User> Users { get; set; }
    }
}
