using Domain.Models;
using Infrastracture.Data;
using Dapper;
namespace Infrastracture.Services;

public class ClassroomStudentService(DapperContext _db) : IClassroomStudentService
{
    
    public async Task<List<Student>> GetStudentsInClassroom(int classroomId)
    {
        var sql = @"
                select s.*
                from students s
                inner join classroomstudents cs on s.id = cs.studentid
                where cs.classroomid = @classroomId";

        var res =  await _db.Connection().QueryAsync<Student>(sql, new { classroomId });
        return res.ToList();
    }

    public async Task AddStudentToClassroom(int classroomId, int studentId)
    {
        var sql = @"
                insert into classroomstudents (classroomid, studentid)
                values (@classroomId, @studentId)";

        await _db.Connection().ExecuteAsync(sql, new { classroomId, studentId });
    }

    public async Task RemoveStudentFromClassroom(int classroomId, int studentId)
    {
        var sql = @"
                delete from classroomstudents
                where classroomid = @classroomId and studentid = @studentId";

        await _db.Connection().ExecuteAsync(sql, new { classroomId, studentId });
    }
}
