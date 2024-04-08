using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class ClassroomService(DapperContext _db) : IClassroomService
{
     public async Task<List<Classroom>> GetClassrooms()
    {
        var sql = "select * from Classroom";
        var res = await _db.Connection().QueryAsync<Classroom>(sql);
        return res.ToList();
    }

    public async Task AddClassroom(Classroom classroom)
    {
        var sql = "insert into Classroom(Year,GradeId,Section,Status,Reamarks,TeacherId)values(@Yaar,@GradeId,@Section,@Status,@Remarks)";
        await _db.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task UpdateClassroom(Classroom classroom)
    {
        var sql =
            "update Classroom set YEar = @Year,GradeId = @GradeId,@Section,Status = @Status,Remarks = @Remarks,TeacherId = @TeacherId where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task DeleteClassroom(int id)
    {
        var sql = "delete from Classroom where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    } 
}
