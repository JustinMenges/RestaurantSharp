using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSharp.Application.CQRS.MenuItems.Commands.Add;
using RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

namespace RestaurantSharp.Presentation.Controllers;

public class MenuItemsController(ISender sender, ILogger<MenuItemsController> logger) : ControllerBase
{
    [HttpGet("GetAvailableAsync")]
    public async Task<IActionResult> GetAvailableAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Received request to get available menu items");
        var request = new GetAvailableMenuItems();
        var result = await sender.Send(request, cancellationToken);

        if (result.IsFailed)
        {
            return Problem(result.Errors.First().Message);
        }
        return Ok(result);
    }

    [HttpPost("CreateAsync")]
    public async Task<IActionResult> CreateMenuItemAsync(AddMenuItemDto addMenuItemDto, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Received request to create a menu item {addMenuItemDto}");
        var request = new AddMenuItem(
             addMenuItemDto.Name,
             addMenuItemDto.Price,
             addMenuItemDto.IsAvailable,
             addMenuItemDto.Description
        );
        var result = await sender.Send(request, cancellationToken);
        if (result.IsFailed)
        {
            return Problem(result.Errors.First().Message);
        }
        return Ok(result);
    }
}
