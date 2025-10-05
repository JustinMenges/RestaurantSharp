using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSharp.Application.CQRS.MenuItems.Commands.Add;
using RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

namespace RestaurantSharp.Presentation.Controllers;

public class MenuItemsController(ISender sender) : ControllerBase
{
    [HttpGet("GetAvailableAsync")]
    public async Task<IActionResult> GetAvailableAsync(CancellationToken cancellationToken)
    {
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
