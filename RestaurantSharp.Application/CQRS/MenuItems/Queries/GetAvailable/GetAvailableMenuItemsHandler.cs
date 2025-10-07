using FluentResults;
using MediatR;
using RestaurantSharp.Application.Common.Interfaces;
using RestaurantSharp.Domain.Models;

namespace RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

public class GetAvailableMenuItemsHandler(IMenuItemRepository menuItemRepository) : IRequestHandler<GetAvailableMenuItems, Result<List<MenuItem>>>
{
    public async Task<Result<List<MenuItem>>> Handle(GetAvailableMenuItems request, CancellationToken cancellationToken)
    {
        var result = await menuItemRepository.GetMenuItemsAsync(x => x.IsAvailable);
        return result;
    }
}
