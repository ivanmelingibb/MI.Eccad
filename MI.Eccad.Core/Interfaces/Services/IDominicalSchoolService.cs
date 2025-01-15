using MI.Eccad.Models.API.Requests.DominicalSchool;
using MI.Eccad.Models.API.Responses;
using MI.Eccad.Models.API.Responses.DominicalSchool;

namespace MI.Eccad.Core.Interfaces.Services;

public interface IDominicalSchoolService
{
    Task<ApiResponse<DominicalSchoolProductResponse>> CreateDominicalSchoolProductAsync(DominicalSchoolProductRequest product);
    Task<IEnumerable<DominicalSchoolProductResponse>> GetActiveDominicalSchoolProductsAsync();
    Task<IEnumerable<DominicalSchoolProductResponse>> GetAllDominicalSchoolProductsAsync();
    Task<DominicalSchoolProductResponse> GetDominicalSchoolProductAsync(int productId);

    Task<ApiResponse<SemesterResponse>> CreateSemesterAsync(SemesterRequest semester);
    Task<IEnumerable<SemesterResponse>> GetSemestersAsync();
    Task<SemesterResponse> GetSemesterAsync(int semesterId);

    Task<ApiResponse<GenerationResponse>> CreateGenerationAsync(GenerationRequest generation);
    Task<IEnumerable<GenerationResponse>> GetGenerationsAsync();
    Task<GenerationResponse> GetGenerationAsync(int generationId);
}