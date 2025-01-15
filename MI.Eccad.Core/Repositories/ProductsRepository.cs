using System.Linq.Expressions;
using MI.Eccad.Core.Data;
using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Models.DTO.Products;

namespace MI.Eccad.Core.Repositories;

public class ProductsRepository(DataContext _context) : BaseRepository(_context), IProductsRepository
{
    public async Task<Product> CreateProductAsync(Product product)
    {
        return await CreateEntityAsync(product);
    }

    public IQueryable<Product> GetProducts()
    {
        return GetEntities<Product>();
    }

    public async Task<ProductCategory> CreateProductCategoryAsync(ProductCategory category)
    {
        return await CreateEntityAsync(category);
    }

    public IQueryable<ProductCategory> GetProductCategories()
    {
        return GetEntities<ProductCategory>();
    }

    public IQueryable<Product> GetProducts(Expression<Func<Product, bool>> predictate)
    {
        return GetEntities(predictate);
    }

    public IQueryable<ProductCategory> GetProductCategories(Expression<Func<ProductCategory, bool>> predictate)
    {
        return GetEntities(predictate);
    }
}
