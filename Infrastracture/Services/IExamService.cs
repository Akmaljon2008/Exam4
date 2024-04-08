namespace Infrastracture.Services;
using Domain.Models;
public interface IExamService
{
    Task<List<ExamService>> GetExams();
    Task AddExam(ExamService examService);
    Task UpdateExam(ExamService examService);
    Task DeleteExam(int id);
}