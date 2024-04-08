using Dapper;
using Domain.Models;
using Infrastracture.Data;

namespace Infrastracture.Services;

public class ExamService(DapperContext _db) : IExamService
{
    public async Task<List<ExamService>> GetExams()
    {
        var sql = "select * from exam";
        var res = await _db.Connection().QueryAsync<ExamService>(sql);
        return res.ToList();
    }

    public async Task AddExam(ExamService examService)
    {
        var sql = "insert into exam(ExamTypeId,Name,StartDate)values (@ExamTypeId,@Name,@StartDate)";
        await _db.Connection().ExecuteAsync(sql, examService);
    }

    public async Task UpdateExam(ExamService examService)
    {
        var sql = "update exam set ExamTypeId = @ExamTypeId,Name = @NAme,StartDate = @StartDate where id = @Id";
        await _db.Connection().ExecuteAsync(sql, examService);
    }

    public async Task DeleteExam(int id)
    {
        var sql = "delete from exam where id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}