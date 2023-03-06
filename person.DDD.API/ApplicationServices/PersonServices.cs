using person.DDD.API.Commands;
using person.DDD.API.Queries;
using person.DDD.Domain.Entities;
using person.DDD.Domain.Repositories;
using person.DDD.Domain.ValueObjects;

namespace person.DDD.API.ApplicationServices
{
    public class PersonServices
    {
        private readonly IPersonRepository repository;
        private readonly PersonQueries personQueries;

        public PersonServices(IPersonRepository repository, PersonQueries personQueries) 
        { 
            this.repository = repository;
            this.personQueries=personQueries;
        }
        //controlador del comando
        public async Task HandleCommand(CreatePersonCommand createPerson)
        {
            var person = new Person(
                PersonId.Create(createPerson.personId));

            person.SetName(PersonName.Create(createPerson.Name));

            await repository.AddPerson(person); 
        }
        //invocación  Queries

        public async Task<Person>GetPerson(Guid Id)
        {
            return await personQueries.GetPersonIdAsync(Id);
        }
    }
}
