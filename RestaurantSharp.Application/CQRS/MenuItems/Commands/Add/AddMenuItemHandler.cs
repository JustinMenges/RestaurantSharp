using FluentResults;
using MediatR;
using RestaurantSharp.Application.Common.Interfaces;
using RestaurantSharp.Domain.Models;

namespace RestaurantSharp.Application.CQRS.MenuItems.Commands.Add;

public class AddMenuItemHandler(IMenuItemRepository menuItemRepository) : IRequestHandler<AddMenuItem, Result<MenuItem>>
{
    public async Task<Result<MenuItem>> Handle(AddMenuItem request, CancellationToken cancellationToken)
    {
        var newMenuItem = new MenuItem()
        {
            Name = request.Name,
            Description = request.Description,
            Id = new Guid(),
            IsAvailable = request.IsAvailable,
            Price = request.Price
        };
        await menuItemRepository.AddMenuItemAsync(newMenuItem);
        return newMenuItem;
    }
}
