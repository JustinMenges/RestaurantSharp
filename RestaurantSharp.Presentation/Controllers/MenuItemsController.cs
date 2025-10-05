using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

namespace RestaurantSharp.Presentation.Controllers;

public class MenuItemsController(ISender sender) : ControllerBase
{
    [HttpGet("pipi")]
    public async Task<IActionResult> GetAvailable(CancellationToken cancellationToken)
    {
        var request = new GetAvailableMenuItems();
        var result = await sender.Send(request, cancellationToken);

        if (result.IsFailed)
        {
            return Problem(result.Errors.First().Message);
        }
        return Ok(result);
    }
}
