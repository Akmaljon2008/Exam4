using Domain.Models;

namespace Infrastracture.Services;

public interface IStudentService
{
   Task<List<Student>> GetStudents();
   Task AddStudent(Student student);
   Task UpdateStudent(Student student);
   Task DeleteStudent(int id);
}