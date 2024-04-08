using Dapper;
using Domain.Models;
using Infrastracture.Data;

namespace Infrastracture.Services;

public class ExamResultService(DapperContext _db) : IExamResultService
{
    public async Task<List<ExamResult>> GetExamResults()
    {
        var sql = "select * from examresult";
        var res = await _db.Connection().QueryAsync<ExamResult>(sql);
        return res.ToList();
    }

    public async Task AddExamResult(ExamResult examResult)
    {
        var sql = "insert into examresult(StudentId,CourseId,Marks)values (@StudentId,@CourseId,@Mark)";
        await _db.Connection().ExecuteAsync(sql, examResult);
    }

    public async Task UpdateExamResult(ExamResult examResult)
    {
        var sql = "update examresult set StudentId = @StudentId,CourseId = @CourseId,Marks = @Marks where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, examResult);
    }

    public async Task DeleteExamResult(int id)
    {
        var sql = "delete from examresult where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}