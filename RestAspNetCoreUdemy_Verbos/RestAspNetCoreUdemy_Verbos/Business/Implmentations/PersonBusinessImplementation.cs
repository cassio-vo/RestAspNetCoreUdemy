using RestAspNetCoreUdemy_Verbos.Data.Converters;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.Model;
using RestAspNetCoreUdemy_Verbos.Model.Context;
using RestAspNetCoreUdemy_Verbos.Repository;
using RestAspNetCoreUdemy_Verbos.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Business.Implmentations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO personVO)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(personVO)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);

        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }


        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO personVO)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(personVO)));
        }
    }
}
