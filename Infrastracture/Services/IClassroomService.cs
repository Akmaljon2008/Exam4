namespace Infrastracture.Services;
using Domain.Models;
public interface IClassroomService
{
    Task<List<Classroom>> GetClassrooms();
   Task AddClassroom(Classroom classroom);
   Task UpdateClassroom(Classroom classroom);
   Task DeleteClassroom(int id);
}
