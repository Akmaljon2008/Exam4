using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassroomStudentController(IClassroomStudentService _service) : ControllerBase
{
   

    [HttpGet("get-students-in-classroom/{classroomId}")]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudentsInClassroom(int classroomId)
    {
        var students = await _service.GetStudentsInClassroom(classroomId);
        return Ok(students);
    }

    [HttpPost("add-student-to-classroom")]
    public async Task<ActionResult> AddStudentToClassroom([FromBody] ClassroomStudent relationship)
    {
        await _service.AddStudentToClassroom(relationship.Id, relationship.StudentId);
        return Ok();
    }

    [HttpDelete("remove-student-from-classroom/{classroomId}/{studentId}")]
    public async Task<ActionResult> RemoveStudentFromClassroom(int classroomId, int studentId)
    {
        await _service.RemoveStudentFromClassroom(classroomId, studentId);
        return Ok();
    }
}