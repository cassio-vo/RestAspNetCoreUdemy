using RestAspNetCoreUdemy_Verbos.Model;
using System.Collections.Generic;

namespace RestAspNetCoreUdemy_Verbos.Service
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(long Id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long Id);
    }
}
