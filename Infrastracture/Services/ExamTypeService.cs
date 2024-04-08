using Infrastracture.Data;
using Domain.Models;
using Dapper;

namespace Infrastracture.Services;
public class ExamTypeService(DapperContext _db) : IExamTypeService
{
     public async Task<List<ExamType>> GetExamTypes()
    {
        var sql = "select * from ExamType";
        var res = await _db.Connection().QueryAsync<ExamType>(sql);
        return res.ToList();
    }

    public async Task AddExamType(ExamType examType)
    {
        var sql = "insert into ExamType(Name,Description)values (@Name,@Description)";
        await _db.Connection().ExecuteAsync(sql, examType);
    }

    public async Task UpdateExamType(ExamType examType)
    {
        var sql =
            "update ExamType set Name = @Name,Description = @Description where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, examType);
    }

    public async Task DeleteExamType(int id)
    {
        var sql = "delete from ExamType where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
