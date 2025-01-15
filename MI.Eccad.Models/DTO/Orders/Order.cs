namespace MI.Eccad.Models.DTO.Orders;

public class Order : BaseEntity
{
    public virtual Client Client { get; set; }
    public virtual Shipment Shipment { get; set; }
    public virtual ICollection<OrderDetail> Details { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
    public DateTime Delivered { get; set; }
    public decimal ShippingFee { get; set; }
}
