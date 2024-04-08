using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController(ITeacherService _service) : ControllerBase
{
   

    [HttpGet("get-teachers")]
    public async Task<ActionResult<List<Teacher>>> GetTeachers()
    {
        var res = await _service.GetTeachers();
        return Ok(res);
    }

    [HttpPost("add-teacher")]
    public async Task<ActionResult> AddTeacher([FromBody] Teacher teacher)
    {
        await _service.AddTeacher(teacher);
        return Ok();
    }

    [HttpPut("update-teacher")]
    public async Task<ActionResult> UpdateTeacher([FromBody] Teacher teacher)
    {
        await _service.UpdateTeacher(teacher);
        return Ok();
    }

    [HttpDelete("delete-teacher/{id}")]
    public async Task<ActionResult> DeleteTeacher(int id)
    {
        await _service.DeleteTeacher(id);
        return Ok();
    }
}