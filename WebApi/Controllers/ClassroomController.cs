using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassroomController(IClassroomService _service) : ControllerBase
{
    [HttpGet("get-classrooms")]
    public async Task<ActionResult<List<Classroom>>> GetClassrooms()
    {
        var res = await _service.GetClassrooms();
        return Ok(res);
    }

    [HttpPost("add-classroom")]
    public async Task<ActionResult> AddClassroom([FromBody] Classroom classroom)
    {
        await _service.AddClassroom(classroom);
        return Ok();
    }

    [HttpPut("update-classroom")]
    public async Task<ActionResult> UpdateClassroom([FromBody] Classroom classroom)
    {
        await _service.UpdateClassroom(classroom);
        return Ok();
    }

    [HttpDelete("delete-classroom/{id}")]
    public async Task<ActionResult> DeleteClassroom(int id)
    {
        await _service.DeleteClassroom(id);
        return Ok();
    }
}