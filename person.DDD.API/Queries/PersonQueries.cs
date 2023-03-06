using person.DDD.Domain.Repositories;
using person.DDD.Domain.Entities;
using person.DDD.Domain.ValueObjects;

namespace person.DDD.API.Queries
{
    public class PersonQueries
    {
        private readonly IPersonRepository personRepository;
        public PersonQueries(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> GetPersonIdAsync(Guid id)
        {
            var response = await personRepository.GetPersonById(
                PersonId.Create(id));
            return response;
        }
    }
}

