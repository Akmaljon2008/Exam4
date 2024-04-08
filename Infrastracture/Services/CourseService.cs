using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class CourseService(DapperContext _db) : ICourseService
{
     public async Task<List<Course>> GetCourses()
    {
        var sql = "select * from Course";
        var res = await _db.Connection().QueryAsync<Course>(sql);
        return res.ToList();
    }

    public async Task AddCourse(Course course)
    {
        var sql = "insert into Course(Name,Description,GradeId)values(@Name,@Description,@GradeId)";
        await _db.Connection().ExecuteAsync(sql, course);
    }

    public async Task UpdateCourse(Course course)
    {
        var sql =
            "update Course set Name = @Name,Desription = @Description,GradeId = @GradeId where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, course);
    }

    public async Task DeleteCourse(int id)
    {
        var sql = "delete from Course where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
