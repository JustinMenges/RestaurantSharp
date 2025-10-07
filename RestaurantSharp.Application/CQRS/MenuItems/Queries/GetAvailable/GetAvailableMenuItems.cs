using FluentResults;
using MediatR;
using RestaurantSharp.Domain.Models;

namespace RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

public record GetAvailableMenuItems : IRequest<Result<List<MenuItem>>>
{ }
