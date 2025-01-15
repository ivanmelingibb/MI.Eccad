namespace MI.Eccad.Models.DTO;

public class OrderDetail : BaseEntity
{
    public Product Product { get; set; }
    public int Requested { get; set; }
    public int Received { get; set; }
    public int Delivered { get; set; }
}
