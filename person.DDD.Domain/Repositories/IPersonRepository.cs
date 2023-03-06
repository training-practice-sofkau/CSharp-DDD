using person.DDD.Domain.Entities;
using person.DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonById(PersonId Id);
        Task AddPerson(Person person);
    }
}
