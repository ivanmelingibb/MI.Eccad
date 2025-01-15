namespace MI.Eccad.Models.DTO.Products;

public class ProductCategory : NamedEntity
{
    public virtual ICollection<Product> Products { get; set; }
}
