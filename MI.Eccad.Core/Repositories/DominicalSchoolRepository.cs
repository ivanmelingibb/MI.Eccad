using System.Linq.Expressions;
using MI.Eccad.Core.Data;
using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Models.DTO.DominicalSchool;
using Microsoft.EntityFrameworkCore;

namespace MI.Eccad.Core.Repositories;

public class DominicalSchoolRepository(DataContext _context) : BaseRepository(_context), IDominicalSchoolRepository
{
    public async Task<DominicalSchoolProduct> CreateDominicalSchoolProductAsync(DominicalSchoolProduct product)
    {
        return await CreateEntityAsync(product);
    }

    public async Task<Generation> CreateGenerationAsync(Generation generation)
    {
        return await CreateEntityAsync(generation);
    }

    public async Task<Semester> CreateSemesterAsync(Semester semester)
    {
        return await CreateEntityAsync(semester);
    }

    public IQueryable<DominicalSchoolProduct> GetDominicalSchoolProducts()
    {
        return GetEntities<DominicalSchoolProduct>()
            .Include(p => p.Category)
            .Include(p => p.Generation)
            .Include(p => p.Semester);
    }

    public IQueryable<DominicalSchoolProduct> GetDominicalSchoolProducts(Expression<Func<DominicalSchoolProduct, bool>> predictate)
    {
        return GetEntities(predictate)
            .Include(p => p.Category)
            .Include(p => p.Generation)
            .Include(p => p.Semester);
    }

    public IQueryable<Generation> GetGenerations()
    {
        return GetEntities<Generation>();
    }

    public IQueryable<Generation> GetGenerations(Expression<Func<Generation, bool>> predictate)
    {
        return GetEntities(predictate);
    }

    public IQueryable<Semester> GetSemesters()
    {
        return GetEntities<Semester>();
    }

    public IQueryable<Semester> GetSemesters(Expression<Func<Semester, bool>> predictate)
    {
        return GetEntities(predictate);
    }
}
