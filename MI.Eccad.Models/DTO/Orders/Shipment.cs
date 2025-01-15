namespace MI.Eccad.Models.DTO.Orders;

public class Shipment : BaseEntity
{
    public DateTime Received { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
