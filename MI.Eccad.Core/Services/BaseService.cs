using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MI.Eccad.Core.Services;

public class BaseService(IBaseRepository _baseRepository)
{
    protected async Task<bool> Exists<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity
    {
        var entities = _baseRepository.GetEntities<T>();
        var existing = await entities.FirstOrDefaultAsync(predicate);
        return existing is not null;
    }

    protected async Task<T> CreateEntityAsync<T>(T entity, Expression<Func<T, bool>> predictate) where T : BaseEntity
    {
        if (await Exists(predictate))
        {
            return null;
        }

        return await _baseRepository.CreateEntityAsync(entity);
    }
}
