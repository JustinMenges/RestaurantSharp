using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RestaurantSharp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddDbContext<RestaurantContext>(options =>
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;"));
        return services;
    }
}
