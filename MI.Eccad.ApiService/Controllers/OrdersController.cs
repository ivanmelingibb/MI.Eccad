using MI.Eccad.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MI.Eccad.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : BaseController<Order>
{
    [HttpPost]
    public override async Task<IActionResult> CreateEntity([FromBody] Order entity)
    {
        return Created();
    }

    [HttpGet]
    public override async Task<IActionResult> GetEntities()
    {
        return Ok();
    }

    [HttpGet("{id:int}")]
    public override async Task<IActionResult> GetEntity(int id)
    {
        return Ok();
    }
}
