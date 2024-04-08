namespace Infrastracture.Services;
using Domain.Models;
public interface IGradeService 
{
    Task<List<Grade>> GetGrades();
   Task AddGrade(Grade grade);
   Task UpdateGrade(Grade grade);
   Task DeleteGrade(int id);
}
