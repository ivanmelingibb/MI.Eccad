using MI.Eccad.Core.Helpers;
using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Core.Interfaces.Services;
using MI.Eccad.Models.API.Requests.DominicalSchool;
using MI.Eccad.Models.API.Responses;
using MI.Eccad.Models.API.Responses.DominicalSchool;

namespace MI.Eccad.Core.Services;

public class DominicalSchoolService(IDominicalSchoolRepository _dominicalSchoolRepository) : BaseService(_dominicalSchoolRepository), IDominicalSchoolService
{
    public async Task<ApiResponse<DominicalSchoolProductResponse>> CreateDominicalSchoolProductAsync(DominicalSchoolProductRequest product)
    {
        var creation = product.ToDTO();
        var created = await CreateEntityAsync(product.ToDTO(), p =>
            p.Name == product.Name &&
            p.Category.Id == product.CategoryId &&
            p.Generation.Id == product.GenerationId &&
            p.Semester.Id == product.SemesterId &&
            p.Type == product.Type &&
            p.Price == product.Price);
        if (created is null)
        {
            return new("Couldn't create the dominical school product.");
        }

        return new(await GetDominicalSchoolProductAsync(created.Id));
    }

    public async Task<ApiResponse<GenerationResponse>> CreateGenerationAsync(GenerationRequest generation)
    {
        var created = await CreateEntityAsync(generation.ToDTO(), g => g.Name == generation.Name);
        if (created is null)
        {
            return new("Couldn't create the dominical school generation.");
        }

        return created.ToResponse();
    }

    public async Task<ApiResponse<SemesterResponse>> CreateSemesterAsync(SemesterRequest semester)
    {
        var created = await CreateEntityAsync(semester.ToDTO(), g => g.Name == semester.Name);
        if (created is null)
        {
            return new("Couldn't create the dominical school semester.");
        }

        return created.ToResponse();
    }

    public async Task<IEnumerable<DominicalSchoolProductResponse>> GetActiveDominicalSchoolProductsAsync()
    {
        return await _dominicalSchoolRepository.GetDominicalSchoolProducts(d => d.IsActive).ToEnumerableResponseAsync();
    }

    public async Task<IEnumerable<DominicalSchoolProductResponse>> GetAllDominicalSchoolProductsAsync()
    {
        return await _dominicalSchoolRepository.GetDominicalSchoolProducts().ToEnumerableResponseAsync();
    }

    public async Task<DominicalSchoolProductResponse> GetDominicalSchoolProductAsync(int productId)
    {
        return await _dominicalSchoolRepository.GetDominicalSchoolProducts(d => d.Id == productId).ToFirstResponseAsync();
    }

    public async Task<GenerationResponse> GetGenerationAsync(int generationId)
    {
        return await _dominicalSchoolRepository.GetGenerations(g => g.Id == generationId).ToFirstResponseAsync();
    }

    public async Task<IEnumerable<GenerationResponse>> GetGenerationsAsync()
    {
        return await _dominicalSchoolRepository.GetGenerations().ToEnumerableResponseAsync();
    }

    public async Task<SemesterResponse> GetSemesterAsync(int semesterId)
    {
        return await _dominicalSchoolRepository.GetSemesters(s => s.Id == semesterId).ToFirstResponseAsync();
    }

    public async Task<IEnumerable<SemesterResponse>> GetSemestersAsync()
    {
        return await _dominicalSchoolRepository.GetSemesters().ToEnumerableResponseAsync();
    }
}