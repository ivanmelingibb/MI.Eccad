using MI.Eccad.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MI.Eccad.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController<TEntity, TRequest> : ControllerBase where TEntity : BaseEntity
{
    public abstract Task<IActionResult> GetEntities();
    public abstract Task<IActionResult> GetEntity(int id);
    public abstract Task<IActionResult> CreateEntity(TRequest entity);
}
