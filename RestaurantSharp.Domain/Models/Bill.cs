using RestaurantSharp.Domain.Common;

namespace RestaurantSharp.Domain.Models;

public class Bill : BaseEntity
{
    public required Order Order { get; set; }
    public Guid OrderId { get; set; }
    public decimal TotalPrice => Order.MenuItems.Sum(item => item.Price);
    public DateTime CreationDate { get; set; }
}
