namespace MI.Eccad.Models.API.Responses.Products;

public class ProductResponse : NamedResponse
{
    public decimal Price { get; set; }
    public CategoryResponse Category { get; set; }
}
