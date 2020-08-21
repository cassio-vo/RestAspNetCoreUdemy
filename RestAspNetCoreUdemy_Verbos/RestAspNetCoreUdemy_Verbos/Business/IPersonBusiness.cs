using RestAspNetCoreUdemy_Verbos.Data.VO;
using System.Collections.Generic;

namespace RestAspNetCoreUdemy_Verbos.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO personVO);

        PersonVO FindById(long Id);

        List<PersonVO> FindAll();

        PersonVO Update(PersonVO personVO);

        void Delete(long Id);
    }
}
