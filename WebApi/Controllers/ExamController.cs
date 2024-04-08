using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamController(IExamService _service) : ControllerBase
{
    [HttpGet("get-exams")]
    public async Task<ActionResult<IEnumerable<Exam>>> GetExams()
    {
        var exams = await _service.GetExams();
        return Ok(exams);
    }

    [HttpPost("add-exam")]
    public async Task<ActionResult> AddExam([FromBody] Exam exam)
    {
        await _service.AddExam(exam);
        return Ok();
    }

    [HttpPut("update-exam")]
    public async Task<ActionResult> UpdateExam([FromBody]Exam exam)
    {
        await _service.UpdateExam(exam);
        return Ok();
    }

    [HttpDelete("delete-exam/{id}")]
    public async Task<ActionResult> DeleteExam(int id)
    {
        await _service.DeleteExam(id);
        return Ok();
    }
}