using RestaurantSharp.Domain.Common;

namespace RestaurantSharp.Domain.Models;

public class MenuItem : BaseEntity
{
    public decimal Price { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
