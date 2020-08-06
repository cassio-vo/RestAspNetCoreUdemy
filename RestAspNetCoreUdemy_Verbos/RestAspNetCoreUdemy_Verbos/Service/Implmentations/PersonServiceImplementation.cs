using RestAspNetCoreUdemy_Verbos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Service.Implmentations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson(i));
            }
            return persons;
        }

        private Person MockPerson(long i)
        {
            return new Person()
            {
                Id = i,
                FirstName = "Cassio",
                LastName = "Vargas",
                Gender = "Homem",
                Adress = "Rio grande do sul"
            };
        }

        public Person FindById(long Id)
        {
            return MockPerson(Id);
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
