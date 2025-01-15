using MI.Eccad.Core.Helpers;
using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Core.Interfaces.Services;
using MI.Eccad.Models.API.Requests.Products;
using MI.Eccad.Models.API.Responses;
using MI.Eccad.Models.API.Responses.Products;
using MI.Eccad.Models.DTO.Products;
using Microsoft.EntityFrameworkCore;

namespace MI.Eccad.Core.Services;

public class ProductsService(IProductsRepository _productsRepository) : BaseService(_productsRepository), IProductsService
{
    public async Task<ApiResponse<ProductResponse>> CreateProductAsync(ProductRequest product)
    {

        var created = await CreateEntityAsync(product.ToDTO(), p => p.Name == product.Name && p.Price == product.Price && p.Category.Id == product.CategoryId);
        if (created is null)
        {
            return new("Couldn't create the product");
        }

        return created?.ToResponse();
    }

    public async Task<ApiResponse<CategoryResponse>> CreateProductCategoryAsync(CategoryRequest category)
    {
        var created = await CreateEntityAsync(category.ToDTO(), c => c.Name == category.Name);
        if (created is null)
        {
            return new("Couldn't create the product");
        }

        return created.ToResponse();
    }

    public async Task<IEnumerable<Product>> GetActiveProductsAsync()
    {
        return await _productsRepository.GetProducts(p => p.IsActive).ToListAsync();
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productsRepository.GetProducts().ToListAsync();
    }

    public async Task<Product> GetProductAsync(int productId)
    {
        return await _productsRepository.GetProducts(p => p.Id == productId).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync()
    {
        return await _productsRepository.GetProductCategories().ToListAsync();
    }

    public async Task<ProductCategory> GetProductCategoryAsync(int categoryId)
    {
        return await _productsRepository.GetProductCategories(c => c.Id == categoryId).FirstOrDefaultAsync();
    }
}
