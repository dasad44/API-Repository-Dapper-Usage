using WebApplication7.Models;

namespace WebApplication7.Interfaces
{
    public interface IRepositoryService
    {
        IEnumerable<Persons> GetPersons();
    }
}
