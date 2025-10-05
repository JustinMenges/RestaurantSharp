using FluentResults;
using MediatR;
using RestaurantSharp.Domain.Models;

namespace RestaurantSharp.Application.CQRS.MenuItems.Commands.Add;

public record AddMenuItem(
    string Name,
    decimal Price,
    bool IsAvailable,
    string? Description) : IRequest<Result<MenuItem>>;
