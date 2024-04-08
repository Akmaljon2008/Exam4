using Domain.Models;

namespace Infrastracture.Services;

public interface IExamResultService
{
    Task<List<ExamResult>> GetExamResults();
    Task AddExamResult(ExamResult examResult);
    Task UpdateExamResult(ExamResult examResult);
    Task DeleteExamResult(int id);
}