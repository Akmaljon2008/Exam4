using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class TeacherService(DapperContext _db) : ITeacherService
{
     public async Task<List<Teacher>> GetTeachers()
    {
        var sql = "select * from Teacher";
        var res = await _db.Connection().QueryAsync<Teacher>(sql);
        return res.ToList();
    }

    public async Task AddTeacher(Teacher teacher)
    {
        var sql = "insert into Teacher(Email,Password,FullName,Dob,PhoneNuber,Mobile,ParentId,DateOfJoin,Status,LastLoginDate,LastLoginIp)values (@Email,@Password,@FullName,@Dob,@PhoneNuber,@Mobile,@ParentId,@DateOfJoin,@Status,@LastLoginDate,@LastLoginIp)";
        await _db.Connection().ExecuteAsync(sql, teacher);
    }

    public async Task UpdateTeacher(Teacher Teacher)
    {
        var sql =
            "update Teacher set Email = @Email,Password = @Password,FullName = @FullName,Dob = @Dob,PhoneNuber = @PhoneNumber,Mobile = @Mobile,ParentId = @ParentId,DateOfJoin = @DateOfJoin,Status = @Status,LastLoginDate = @LastJOinDate,LastLoginIp = @LastJOinIp where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, Teacher);
    }

    public async Task DeleteTeacher(int id)
    {
        var sql = "delete from Teacher where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
