namespace MI.Eccad.Models.DTO;

public class Shipment : BaseEntity
{
    public DateTime Received { get; set; }
    public List<Order> Orders { get; set; }
}
