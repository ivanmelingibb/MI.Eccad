using MI.Eccad.Models.DTO.Products;

namespace MI.Eccad.Models.DTO.Orders;

public class OrderDetail : BaseEntity
{
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }

    public int Requested { get; set; }
    public int Received { get; set; }
    public int Delivered { get; set; }
}
