using MI.Eccad.Core.Interfaces.Services;
using MI.Eccad.Models.API.Requests.DominicalSchool;
using MI.Eccad.Models.DTO.DominicalSchool;
using Microsoft.AspNetCore.Mvc;

namespace MI.Eccad.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DominicalSchoolController(IDominicalSchoolService _dominicalSchoolService) : BaseController<DominicalSchoolProduct, DominicalSchoolProductRequest>
{
    [HttpPost("products")]
    public override async Task<IActionResult> CreateEntity(DominicalSchoolProductRequest entity)
    {
        var product = await _dominicalSchoolService.CreateDominicalSchoolProductAsync(entity);
        if (product.Error)
        {
            return UnprocessableEntity(product);
        }

        return CreatedAtAction(nameof(GetEntity), new { productId = product.Data.Id }, product);
    }

    [HttpGet("products")]
    public async override Task<IActionResult> GetEntities()
    {
        var products = await _dominicalSchoolService.GetAllDominicalSchoolProductsAsync();
        return Ok(products);
    }

    [HttpGet("products/{productId:int}")]
    public async override Task<IActionResult> GetEntity(int productId)
    {
        var product = await _dominicalSchoolService.GetDominicalSchoolProductAsync(productId);
        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost("semesters")]
    public async Task<IActionResult> CreateSemester(SemesterRequest entity)
    {
        var semester = await _dominicalSchoolService.CreateSemesterAsync(entity);
        if (semester.Error)
        {
            return UnprocessableEntity(semester);
        }

        return CreatedAtAction(nameof(GetSemester), new { semesterId = semester.Data.Id }, semester);
    }

    [HttpGet("semesters")]
    public async Task<IActionResult> GetSemesters()
    {
        var semesters = await _dominicalSchoolService.GetSemestersAsync();
        return Ok(semesters);
    }

    [HttpGet("semesters/{semesterId:int}")]
    public async Task<IActionResult> GetSemester(int semesterId)
    {
        var semester = await _dominicalSchoolService.GetSemesterAsync(semesterId);
        if (semester is null)
        {
            return NotFound();
        }

        return Ok(semester);
    }

    [HttpPost("generations")]
    public async Task<IActionResult> CreateGeneration(GenerationRequest entity)
    {
        var generation = await _dominicalSchoolService.CreateGenerationAsync(entity);
        if (generation.Error)
        {
            return UnprocessableEntity(generation);
        }

        return CreatedAtAction(nameof(GetGeneration), new { generationId = generation.Data.Id }, generation);
    }

    [HttpGet("generations")]
    public async Task<IActionResult> GetGenerations()
    {
        var generations = await _dominicalSchoolService.GetGenerationsAsync();
        return Ok(generations);
    }

    [HttpGet("generations/{generationId:int}")]
    public async Task<IActionResult> GetGeneration(int generationId)
    {
        var generation = await _dominicalSchoolService.GetSemesterAsync(generationId);
        if (generation is null)
        {
            return NotFound();
        }

        return Ok(generation);
    }
}