namespace MI.Eccad.Models.DTO;

public class Order : BaseEntity
{
    public Client Client { get; set; }
    public List<OrderDetail> Details { get; set; }
    public List<Payment> Payments { get; set; }
    public DateTime Delivered { get; set; }
    public decimal ShippingFee { get; set; }
}
