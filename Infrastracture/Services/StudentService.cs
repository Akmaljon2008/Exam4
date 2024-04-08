using Dapper;
using Domain.Models;
using Infrastracture.Data;

namespace Infrastracture.Services;

public class StudentService(DapperContext _db) : IStudentService
{
    public async Task<List<Student>> GetStudents()
    {
        var sql = "select * from student";
        var res = await _db.Connection().QueryAsync<Student>(sql);
        return res.ToList();
    }

    public async Task AddStudent(Student student)
    {
        var sql = "insert into student(Email,Password,FullName,Dob,PhoneNuber,Mobile,ParentId,DateOfJoin,Status,LastLoginDate,LastLoginIp)values (@Email,@Password,@FullName,@Dob,@PhoneNuber,@Mobile,@ParentId,@DateOfJoin,@Status,@LastLoginDate,@LastLoginIp)";
        await _db.Connection().ExecuteAsync(sql, student);
    }

    public async Task UpdateStudent(Student student)
    {
        var sql =
            "update student set Email = @Email,Password = @Password,FullName = @FullName,Dob = @Dob,PhoneNuber = @PhoneNumber,Mobile = @Mobile,ParentId = @ParentId,DateOfJoin = @DateOfJoin,Status = @Status,LastLoginDate = @LastJOinDate,LastLoginIp = @LastJOinIp where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, student);
    }

    public async Task DeleteStudent(int id)
    {
        var sql = "delete from student where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}