using eCommerce.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess
{
    public class IdentityUserContext : IdentityDbContext<Identity>
    {
        public IdentityUserContext(DbContextOptions<IdentityUserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
