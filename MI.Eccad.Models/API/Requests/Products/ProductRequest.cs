namespace MI.Eccad.Models.API.Requests.Products;

public class ProductRequest : NamedRequest
{
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
