using RestAspNetCoreUdemy_Verbos.Data.Converter;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Data.Converters
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null)
                return null;
            else
                return new Person {
                    Id = origin.Id,
                    Address = origin.Address,
                    FirstName = origin.FirstName,
                    Gender = origin.Gender,
                    LastName = origin.LastName,
                };
        }

        public List<Person> ParseList(List<PersonVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null)
                return null;
            else
                return new PersonVO
                {
                    Id = origin.Id,
                    Address = origin.Address,
                    FirstName = origin.FirstName,
                    Gender = origin.Gender,
                    LastName = origin.LastName,
                };
        }       

        public List<PersonVO> ParseList(List<Person> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
