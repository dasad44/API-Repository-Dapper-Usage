using WebApplication7.Models;

namespace WebApplication7.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Persons> GetPersons();
    }
}
