using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController(ICourseService _service) : ControllerBase
{
   
    [HttpGet("get-courses")]
    public async Task<ActionResult<List<Course>>> GetCourses()
    {
        var res = await _service.GetCourses();
        return Ok(res);
    }

    [HttpPost("add-course")]
    public async Task<ActionResult> AddCourse([FromBody] Course course)
    {
        await _service.AddCourse(course);
        return Ok();
    }

    [HttpPut("update-course")]
    public async Task<ActionResult> UpdateCourse([FromBody] Course course)
    {
        await _service.UpdateCourse(course);
        return Ok();
    }

    [HttpDelete("delete-course/{id}")]
    public async Task<ActionResult> DeleteCourse(int id)
    {
        await _service.DeleteCourse(id);
        return Ok();
    }
}