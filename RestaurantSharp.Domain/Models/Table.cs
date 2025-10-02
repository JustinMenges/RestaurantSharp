using RestaurantSharp.Domain.Common;

namespace RestaurantSharp.Domain.Models;

public class Table : BaseEntity
{
    public int Seats { get; set; }
}
