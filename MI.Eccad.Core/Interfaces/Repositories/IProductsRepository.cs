using System.Linq.Expressions;
using MI.Eccad.Models.DTO.Products;

namespace MI.Eccad.Core.Interfaces.Repositories;

public interface IProductsRepository : IBaseRepository
{
    Task<Product> CreateProductAsync(Product product);
    IQueryable<Product> GetProducts();
    IQueryable<Product> GetProducts(Expression<Func<Product, bool>> predictate);

    Task<ProductCategory> CreateProductCategoryAsync(ProductCategory category);
    IQueryable<ProductCategory> GetProductCategories();
    IQueryable<ProductCategory> GetProductCategories(Expression<Func<ProductCategory, bool>> predictate);
}
