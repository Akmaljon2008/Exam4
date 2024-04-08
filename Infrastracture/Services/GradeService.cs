using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class GradeService(DapperContext _db) : IGradeService 
{
     public async Task<List<Grade>> GetGrades()
    {
        var sql = "select * from Grade";
        var res = await _db.Connection().QueryAsync<Grade>(sql);
        return res.ToList();
    }

    public async Task AddGrade(Grade grade)
    {
        var sql = "insert into Grade(Name,Description)values(@Name,@Description)";
        await _db.Connection().ExecuteAsync(sql, grade);
    }

    public async Task UpdateGrade(Grade grade)
    {
        var sql =
            "update Grade set Name = @Name,Description = @Description where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, grade);
    }

    public async Task DeleteGrade(int id)
    {
        var sql = "delete from Grade where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
