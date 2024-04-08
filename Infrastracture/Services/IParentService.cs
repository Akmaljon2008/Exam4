using Domain.Models;



namespace Infrastracture.Services;

public interface IParentService
{
    Task<List<Parent>> GetParents();
   Task AddParent(Parent parent);
   Task UpdateParent(Parent parent);
   Task DeleteParent(int id);
}
