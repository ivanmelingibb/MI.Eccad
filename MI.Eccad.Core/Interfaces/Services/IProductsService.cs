using MI.Eccad.Models.API.Requests.Products;
using MI.Eccad.Models.API.Responses;
using MI.Eccad.Models.API.Responses.Products;
using MI.Eccad.Models.DTO.Products;

namespace MI.Eccad.Core.Interfaces.Services;

public interface IProductsService
{
    Task<ApiResponse<ProductResponse>> CreateProductAsync(ProductRequest product);
    Task<IEnumerable<Product>> GetActiveProductsAsync();
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product> GetProductAsync(int productId);

    Task<ApiResponse<CategoryResponse>> CreateProductCategoryAsync(CategoryRequest category);
    Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync();
    Task<ProductCategory> GetProductCategoryAsync(int productId);
}
