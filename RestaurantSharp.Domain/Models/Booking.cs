using RestaurantSharp.Domain.Common;

namespace RestaurantSharp.Domain.Models;

public class Booking : BaseEntity
{
    public required string BookingName { get; set; }
    public required DateTime BookingDate { get; set; }
    public required uint NumberOfGuests { get; set; }
    public required Guid TableId { get; set; }
    public required Table Table { get; set; }
}
