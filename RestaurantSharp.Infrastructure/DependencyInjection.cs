using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RestaurantSharp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddDbContext<RestaurantContext>(options =>
        options.UseSqlite("Data source = test.db"));
        return services;
    }
}
