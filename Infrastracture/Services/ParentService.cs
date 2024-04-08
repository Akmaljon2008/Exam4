using Infrastracture.Data;
using Domain.Models;
using Dapper;
namespace Infrastracture.Services;

public class ParentService(DapperContext _db) : IParentService
{
     public async Task<List<Parent>> GetParents()
    {
        var sql = "select * from Parent";
        var res = await _db.Connection().QueryAsync<Parent>(sql);
        return res.ToList();
    }

    public async Task AddParent(Parent Parent)
    {
        var sql = "insert into Parent(Email,Password,FullName,Dob,PhoneNuber,Mobile,DateOfJoin,Status,LastLoginDate,LastLoginIp)values (@Email,@Password,@FullName,@Dob,@PhoneNuber,@Mobile,@DateOfJoin,@Status,@LastLoginDate,@LastLoginIp)";
        await _db.Connection().ExecuteAsync(sql, Parent);
    }

    public async Task UpdateParent(Parent Parent)
    {
        var sql =
            "update Parent set Email = @Email,Password = @Password,FullName = @FullName,Dob = @Dob,PhoneNuber = @PhoneNumber,Mobile = @Mobile,DateOfJoin = @DateOfJoin,Status = @Status,LastLoginDate = @LastJOinDate,LastLoginIp = @LastJOinIp where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, Parent);
    }

    public async Task DeleteParent(int id)
    {
        var sql = "delete from Parent where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
