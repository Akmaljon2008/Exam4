using Domain.Models;

namespace Infrastracture.Services;

public interface IClassroomStudentService
{
    
        Task<List<Student>> GetStudentsInClassroom(int classroomId);
        Task AddStudentToClassroom(int classroomId, int studentId);
        Task RemoveStudentFromClassroom(int classroomId, int studentId);
    

}