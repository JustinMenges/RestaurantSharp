namespace RestaurantSharp.Application.CQRS.MenuItem.Queries.GetAvailable;

public record GetAvailableMenuItemsDto
(
    Guid Id,
    string Name,
    decimal Price,
    bool IsAvailable,
    string? Description
);