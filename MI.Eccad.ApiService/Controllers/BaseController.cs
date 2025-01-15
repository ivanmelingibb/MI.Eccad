using MI.Eccad.Models;
using Microsoft.AspNetCore.Mvc;

namespace MI.Eccad.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController<T> : ControllerBase where T : BaseEntity
{
    public abstract Task<IActionResult> GetEntities();
    public abstract Task<IActionResult> GetEntity(int id);
    public abstract Task<IActionResult> CreateEntity(T entity);
}
