using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GradeController(IGradeService _service) : ControllerBase
{
    [HttpGet("get-grades")]
    public async Task<ActionResult<List<Grade>>> GetGrades()
    {
        var res = await _service.GetGrades();
        return Ok(res);
    }

    [HttpPost("add-grade")]
    public async Task<ActionResult> AddGrade([FromBody] Grade grade)
    {
        await _service.AddGrade(grade);
        return Ok();
    }

    [HttpPut("update-grade")]
    public async Task<ActionResult> UpdateGrade([FromBody] Grade grade)
    {
        await _service.UpdateGrade(grade);
        return Ok();
    }

    [HttpDelete("delete-grade/{id}")]
    public async Task<ActionResult> DeleteGrade(int id)
    {
        await _service.DeleteGrade(id);
        return Ok();
    }
}