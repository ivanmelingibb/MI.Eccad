using MI.Eccad.Models.API.Requests.DominicalSchool;
using MI.Eccad.Models.API.Requests.Products;
using MI.Eccad.Models.API.Responses;
using MI.Eccad.Models.API.Responses.DominicalSchool;
using MI.Eccad.Models.API.Responses.Products;
using MI.Eccad.Models.DTO.DominicalSchool;
using MI.Eccad.Models.DTO.Products;
using Microsoft.EntityFrameworkCore;

namespace MI.Eccad.Core.Helpers;

internal static class Extensions
{
    internal static async Task<IEnumerable<ProductResponse>> ToEnumerableResponseAsync(this IQueryable<Product> products) => await products.Select(p => p.ToResponse().Data).ToListAsync();
    internal static async Task<IEnumerable<CategoryResponse>> ToEnumerableResponseAsync(this IQueryable<ProductCategory> categories) => await categories.Select(c => c.ToResponse().Data).ToListAsync();
    internal static async Task<IEnumerable<DominicalSchoolProductResponse>> ToEnumerableResponseAsync(this IQueryable<DominicalSchoolProduct> products) => await products.Select(p => p.ToResponse().Data).ToListAsync();
    internal static async Task<IEnumerable<SemesterResponse>> ToEnumerableResponseAsync(this IQueryable<Semester> semesters) => await semesters.Select(s => s.ToResponse().Data).ToListAsync();
    internal static async Task<IEnumerable<GenerationResponse>> ToEnumerableResponseAsync(this IQueryable<Generation> generations) => await generations.Select(g => g.ToResponse().Data).ToListAsync();

    internal static async Task<ProductResponse> ToFirstResponseAsync(this IQueryable<Product> products) => await products.Select(p => p.ToResponse().Data).FirstOrDefaultAsync();
    internal static async Task<CategoryResponse> ToFirstResponseAsync(this IQueryable<ProductCategory> categories) => await categories.Select(c => c.ToResponse().Data).FirstOrDefaultAsync();
    internal static async Task<DominicalSchoolProductResponse> ToFirstResponseAsync(this IQueryable<DominicalSchoolProduct> products) => await products.Select(p => p.ToResponse().Data).FirstOrDefaultAsync();
    internal static async Task<SemesterResponse> ToFirstResponseAsync(this IQueryable<Semester> semesters) => await semesters.Select(s => s.ToResponse().Data).FirstOrDefaultAsync();
    internal static async Task<GenerationResponse> ToFirstResponseAsync(this IQueryable<Generation> generations) => await generations.Select(g => g.ToResponse().Data).FirstOrDefaultAsync();

    internal static Product ToDTO(this ProductRequest product) => new()
    {
        Category = new()
        {
            Id = product.CategoryId
        },
        IsActive = true,
        Name = product.Name,
        Price = product.Price
    };

    internal static ApiResponse<ProductResponse> ToResponse(this Product product) => new(new ProductResponse
    {
        Category = product.Category.ToResponse().Data,
        Created = product.Created,
        Id = product.Id,
        Name = product.Name,
        Price = product.Price
    });

    internal static ProductCategory ToDTO(this CategoryRequest category) => new()
    {
        Name = category.Name
    };

    internal static ApiResponse<CategoryResponse> ToResponse(this ProductCategory category) => new(new CategoryResponse
    {
        Created = category.Created,
        Id = category.Id,
        Name = category.Name
    });

    internal static DominicalSchoolProduct ToDTO(this DominicalSchoolProductRequest product) => new()
    {
        IsActive = true,
        Category = new()
        {
            Id = product.CategoryId
        },
        Generation = new()
        {
            Id = product.GenerationId
        },
        Name = product.Name,
        Price= product.Price,
        Semester = new()
        {
            Id = product.SemesterId
        },
        Type = product.Type
    };

    internal static ApiResponse<DominicalSchoolProductResponse> ToResponse(this DominicalSchoolProduct product) => new(new DominicalSchoolProductResponse
    {
        Category = product.Category.ToResponse().Data,
        Created = product.Created,
        Generation = product.Generation.ToResponse().Data,
        Id = product.Id,
        Name = product.Name,
        Price = product.Price,
        Semester = product.Semester.ToResponse().Data,
        Type = product.Type
    });

    internal static Generation ToDTO(this GenerationRequest generation) => new()
    {
        Description = generation.Description,
        Name = generation.Name
    };

    internal static ApiResponse<GenerationResponse> ToResponse(this Generation generation) => new(new GenerationResponse
    {
        Created = generation.Created,
        Description = generation.Description,
        Id = generation.Id,
        Name = generation.Name,
    });

    internal static Semester ToDTO(this SemesterRequest semester) => new()
    {
        Name = semester.Name
    };

    internal static ApiResponse<SemesterResponse> ToResponse(this Semester semester) => new(new SemesterResponse
    {
        Created = semester.Created,        
        Id = semester.Id,
        Name = semester.Name
    });
}
