using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class AttendancyService(DapperContext _db) : IAttendencyService
{
     public async Task<List<Attendancy>> GetAttendancys()
    {
        var sql = "select * from Attendancy";
        var res = await _db.Connection().QueryAsync<Attendancy>(sql);
        return res.ToList();
    }

    public async Task AddAttendancy(Attendancy attendancy)
    {
        var sql = "insert into Attendancy(Date,StudentId,Status,Remark)values (@Date,@StudentId,@Status,@Reamrk)";
        await _db.Connection().ExecuteAsync(sql, attendancy);
    }

    public async Task UpdateAttendancy(Attendancy attendancy)
    {
        var sql =
            "update Attendancy set Date = @Date,StudentId = @StudentId,Status = @Status,Remark = @ Remark where Id = @ID";
        await _db.Connection().ExecuteAsync(sql, attendancy);
    }

    public async Task DeleteAttendancy(int id)
    {
        var sql = "delete from Attendancy where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
