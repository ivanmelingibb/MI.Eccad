using MI.Eccad.Models.DTO.Orders;

namespace MI.Eccad.Models.DTO.Products;

public class Product : NamedEntity
{
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public virtual ProductCategory Category { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}
