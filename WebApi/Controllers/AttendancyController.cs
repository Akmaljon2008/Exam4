using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AttendanceController(IAttendencyService _service) : ControllerBase
{
    

    [HttpGet("get-attendancys")]
    public async Task<ActionResult<IEnumerable<Attendancy>>> GetAttendancys()
    {
        var attendancys = await _service.GetAttendancys();
        return Ok(attendancys);
    }

    [HttpPost("add-attendancy")]
    public async Task<ActionResult> AddAttendancy([FromBody] Attendancy attendancy)
    {
        await _service.AddAttendancy(attendancy);
        return Ok();
    }

    [HttpPut("update-attendancy")]
    public async Task<ActionResult> UpdateAttendancy([FromBody] Attendancy attendancy)
    {
        await _service.UpdateAttendancy(attendancy);
        return Ok();
    }

    [HttpDelete("delete-attendancy/{id}")]
    public async Task<ActionResult> DeleteAttendancy(int id)
    {
        await _service.DeleteAttendancy(id);
        return Ok();
    }
}