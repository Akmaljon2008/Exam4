using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ParentController(IParentService _service) : ControllerBase
{
    

    [HttpGet("get-parents")]
    public async Task<ActionResult<List<Parent>>> GetParents()
    {
        var res = await _service.GetParents();
        return Ok(res);
    }

    [HttpPost("add-parent")]
    public async Task<ActionResult> AddParent([FromBody] Parent parent)
    {
        await _service.AddParent(parent);
        return Ok();
    }

    [HttpPut("update-parent")]
    public async Task<ActionResult> UpdateParent([FromBody] Parent parent)
    {
        await _service.UpdateParent(parent);
        return Ok();
    }

    [HttpDelete("delete-parent/{id}")]
    public async Task<ActionResult> DeleteParent(int id)
    {
        await _service.DeleteParent(id);
        return Ok();
    }
}