using eCommerce.ApplicationCore.Services;
using eCommerce.Domain.Entities.Users;
using eCommerce.Infrastructure.EntityFrameworkDataAccess.Repositories;
using eCommerce.Infrastructure.EntityFrameworkDataAccess.UOW;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess
{
    public static class ServicesDI
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
