using Microsoft.EntityFrameworkCore;
using RestaurantSharp.Domain.Models;
using System.Linq.Expressions;

namespace RestaurantSharp.Infrastructure.Repositories;

public class MenuItemRepository(RestaurantContext restaurantContext)
{
    public async Task AddMenuItemAsync(MenuItem menuItem)
    {
        restaurantContext.MenuItems.Add(menuItem);
        await restaurantContext.SaveChangesAsync();
    }

    public async Task<List<MenuItem>> GetMenuItemsAsync(Expression<Func<MenuItem, bool>> predicate)
    {
        return await restaurantContext.MenuItems.Where(predicate).AsNoTracking().ToListAsync();
    }

    public async Task<MenuItem?> GetMenuItemByIdAsync(Guid id)
    {
        return await restaurantContext.MenuItems
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateMenuItemAsync(MenuItem menuItem)
    {
        restaurantContext.MenuItems.Update(menuItem);
        await restaurantContext.SaveChangesAsync();
    }

    public async Task DeleteMenuItemAsync(MenuItem menuItem)
    {
        restaurantContext.MenuItems.Remove(menuItem);
        await restaurantContext.SaveChangesAsync();
    }
}
