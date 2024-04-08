namespace Infrastracture.Services;
using Domain.Models;
public interface ICourseService
{
    Task<List<Course>> GetCourses();
   Task AddCourse(Course course);
   Task UpdateCourse(Course course);
   Task DeleteCourse(int id);
}
