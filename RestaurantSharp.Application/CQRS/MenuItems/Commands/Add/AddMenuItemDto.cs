namespace RestaurantSharp.Application.CQRS.MenuItems.Commands.Add;

public record AddMenuItemDto(
    string Name,
    decimal Price,
    bool IsAvailable,
    string? Description
    );
