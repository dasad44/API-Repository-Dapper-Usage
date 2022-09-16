using WebApplication7.Infrastructure.Repositories;
using WebApplication7.Interfaces;
using WebApplication7.Models;

namespace WebApplication7.Core.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly IPersonRepository _personRepository;

        public RepositoryService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public IEnumerable<Persons> GetPersons()
        {
            return _personRepository.GetPersons();
        }
    }
}
