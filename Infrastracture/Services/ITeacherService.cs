using Domain.Models;
namespace Infrastracture.Services;

public interface ITeacherService
{
    Task<List<Teacher>> GetTeachers();
   Task AddTeacher(Teacher teacher);
   Task UpdateTeacher(Teacher teacher);
   Task DeleteTeacher(int id);
}
