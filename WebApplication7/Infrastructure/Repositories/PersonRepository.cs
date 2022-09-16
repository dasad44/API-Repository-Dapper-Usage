using Dapper;
using System.Data.SqlClient;
using WebApplication7.Interfaces;
using WebApplication7.Models;

namespace WebApplication7.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SqlConnection _connection;
        private readonly IConfiguration _configuration;
        public PersonRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("MainDB"));
        }

        public IEnumerable<Persons> GetPersons()
        {
            _connection.Open();
            return _connection.Query<Persons>("select * from Persons");
        }

    }
}
