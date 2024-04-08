using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController(IStudentService _service) : ControllerBase
{
    

    [HttpGet("get-students")]
    public async Task<ActionResult<List<Student>>> GetStudents()
    {
        var res = await _service.GetStudents();
        return Ok(res);
    }

    [HttpPost("add-student")]
    public async Task<ActionResult> AddStudent([FromBody] Student student)
    {
        await _service.AddStudent(student);
        return Ok();
    }

    [HttpPut("update-student")]
    public async Task<ActionResult> UpdateStudent([FromBody] Student student)
    {
        await _service.UpdateStudent(student);
        return Ok();
    }

    [HttpDelete("delete-student/{id}")]
    public async Task<ActionResult> DeleteStudent(int id)
    {
        await _service.DeleteStudent(id);
        return Ok();
    }
}