namespace RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

public record GetAvailableMenuItemsDto
(
    Guid Id,
    string Name,
    decimal Price,
    bool IsAvailable,
    string? Description
);