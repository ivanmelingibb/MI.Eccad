namespace MI.Eccad.Models.DTO;

public class Product : NamedEntity
{
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public ProductCategory Category { get; set; }
}
