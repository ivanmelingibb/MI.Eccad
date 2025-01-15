using System.Linq.Expressions;
using MI.Eccad.Models.DTO.DominicalSchool;

namespace MI.Eccad.Core.Interfaces.Repositories;

public interface IDominicalSchoolRepository : IBaseRepository
{
    Task<DominicalSchoolProduct> CreateDominicalSchoolProductAsync(DominicalSchoolProduct product);
    IQueryable<DominicalSchoolProduct> GetDominicalSchoolProducts();
    IQueryable<DominicalSchoolProduct> GetDominicalSchoolProducts(Expression<Func<DominicalSchoolProduct, bool>> predictate);

    Task<Semester> CreateSemesterAsync(Semester semester);
    IQueryable<Semester> GetSemesters();
    IQueryable<Semester> GetSemesters(Expression<Func<Semester, bool>> predictate);

    Task<Generation> CreateGenerationAsync(Generation generation);
    IQueryable<Generation> GetGenerations();
    IQueryable<Generation> GetGenerations(Expression<Func<Generation, bool>> predictate);
}