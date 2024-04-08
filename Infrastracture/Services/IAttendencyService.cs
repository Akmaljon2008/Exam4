namespace Infrastracture.Services;
using Domain.Models;
public interface IAttendencyService
{
    Task<List<Attendancy>> GetAttendancys();
   Task AddAttendancy(Attendancy attendancy);
   Task UpdateAttendancy(Attendancy attendancy);
   Task DeleteAttendancy(int id);
}
