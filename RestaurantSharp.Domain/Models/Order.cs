using RestaurantSharp.Domain.Common;

namespace RestaurantSharp.Domain.Models;

public class Order : BaseEntity
{
    public DateTime CreationDate { get; set; }
    public required List<MenuItem> MenuItems { get; set; }
    public Guid TableId { get; set; }
    public required Table Table { get; set; }
}
