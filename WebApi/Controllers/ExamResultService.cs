using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamResultController(IExamResultService _service) : ControllerBase
{
    [HttpGet("get-exam-results")]
    public async Task<ActionResult<IEnumerable<ExamResult>>> GetExamResults()
    {
        var examResults = await _service.GetExamResults();
        return Ok(examResults);
    }

    [HttpPost("add-exam-result")]
    public async Task<ActionResult> AddExamResult([FromBody] ExamResult examResult)
    {
        await _service.AddExamResult(examResult);
        return Ok();
    }

    [HttpPut("update-exam-result")]
    public async Task<ActionResult> UpdateExamResult([FromBody] ExamResult examResult)
    {
        await _service.UpdateExamResult(examResult);
        return Ok();
    }

    [HttpDelete("delete-exam-result/{id}")]
    public async Task<ActionResult> DeleteExamResult(int id)
    {
        await _service.DeleteExamResult(id);
        return Ok();
    }
}