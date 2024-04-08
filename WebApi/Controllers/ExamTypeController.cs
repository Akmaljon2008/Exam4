using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;
 

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamTypeController(IExamTypeService _service) : ControllerBase
{
    

    [HttpGet("get-exam-types")]
    public async Task<ActionResult<IEnumerable<ExamType>>> GetExamTypes()
    {
        var examTypes = await _service.GetExamTypes();
        return Ok(examTypes);
    }

    [HttpPost("add-exam-type")]
    public async Task<ActionResult> AddExamType([FromBody] ExamType examType)
    {
        await _service.AddExamType(examType);
        return Ok();
    }

    [HttpPut("update-exam-type")]
    public async Task<ActionResult> UpdateExamType([FromBody] ExamType examType)
    {
        await _service.UpdateExamType(examType);
        return Ok();
    }

    [HttpDelete("delete-exam-type/{id}")]
    public async Task<ActionResult> DeleteExamType(int id)
    {
        await _service.DeleteExamType(id);
        return Ok();
    }
}