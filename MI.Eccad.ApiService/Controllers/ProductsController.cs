using MI.Eccad.Core.Interfaces.Services;
using MI.Eccad.Models.API.Requests.Products;
using MI.Eccad.Models.DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace MI.Eccad.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductsService _productsService) : BaseController<Product, ProductRequest>
{
    [HttpPost]
    public override async Task<IActionResult> CreateEntity([FromBody] ProductRequest entity)
    {
        var product = await _productsService.CreateProductAsync(entity);
        if (product.Error)
        {
            return UnprocessableEntity(product);
        }

        return CreatedAtAction(nameof(GetEntity), new { productId = product.Data.Id }, product);
    }

    [HttpGet]
    public override async Task<IActionResult> GetEntities()
    {
        var products = await _productsService.GetAllProductsAsync();
        return Ok(products);
    }

    [HttpGet("{productId:int}")]
    public override async Task<IActionResult> GetEntity(int productId)
    {
        var product = await _productsService.GetProductAsync(productId);
        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost("categories")]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryRequest entity)
    {
        var category = await _productsService.CreateProductCategoryAsync(entity);
        if (category.Error)
        {
            return UnprocessableEntity();
        }

        return CreatedAtAction(nameof(GetCategory), new { categoryId = category.Data.Id }, category);
    }

    [HttpGet("categories")]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _productsService.GetProductCategoriesAsync();
        return Ok(categories);
    }

    [HttpGet("categories/{categoryId:int}")]
    public async Task<IActionResult> GetCategory(int categoryId)
    {
        var category = await _productsService.GetProductCategoryAsync(categoryId);
        if (category is null)
        {
            return NotFound();
        }

        return Ok(category);
    }
}
