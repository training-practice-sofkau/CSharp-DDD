using person.DDD.Domain.Entities;
using person.DDD.Domain.Repositories;
using person.DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        DataBaseContext db;

        public PersonRepository(DataBaseContext db_)
        {
            db = db_;
        }

        //implementación interfaces
        public async Task AddPerson(Person person)
        {
            await db.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public async Task<Person> GetPersonById(PersonId Id)
        {
            return await db.Persons.FindAsync((Guid)Id);
        }
    }
}
