using RestaurantSharp.Domain.Models;
using System.Linq.Expressions;

namespace RestaurantSharp.Application.Common.Interfaces;

public interface IMenuItemRepository
{
    Task AddMenuItemAsync(MenuItem menuItem);
    Task DeleteMenuItemAsync(MenuItem menuItem);
    Task<MenuItem?> GetMenuItemByIdAsync(Guid id);
    Task<List<MenuItem>> GetMenuItemsAsync(Expression<Func<MenuItem, bool>> predicate);
    Task UpdateMenuItemAsync(MenuItem menuItem);
}