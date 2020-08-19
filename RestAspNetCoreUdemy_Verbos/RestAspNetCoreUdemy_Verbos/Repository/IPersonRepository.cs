using RestAspNetCoreUdemy_Verbos.Model;
using System.Collections.Generic;

namespace RestAspNetCoreUdemy_Verbos.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindById(long Id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long Id);

        bool Exist(long id);
    }
}
