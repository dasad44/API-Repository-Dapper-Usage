using Microsoft.AspNetCore.Mvc;
using WebApplication7.Core.Services;
using WebApplication7.Interfaces;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IRepositoryService _repositoryService;

        public HomeController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        [HttpGet]
        public IEnumerable<Persons> GetPersons()
        {
            return _repositoryService.GetPersons();
        }
    }
}
