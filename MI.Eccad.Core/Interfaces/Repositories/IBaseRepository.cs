using System.Linq.Expressions;
using MI.Eccad.Models.DTO;

namespace MI.Eccad.Core.Interfaces.Repositories;

public interface IBaseRepository
{
    Task<T> CreateEntityAsync<T>(T entity) where T : BaseEntity;
    IQueryable<T> GetEntities<T>() where T : BaseEntity;
    IQueryable<T> GetEntities<T>(Expression<Func<T, bool>> predictate) where T : BaseEntity;
}
