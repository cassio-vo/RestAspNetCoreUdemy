using RestAspNetCoreUdemy_Verbos.Data.VO;
using System.Collections.Generic;

namespace RestAspNetCoreUdemy_Verbos.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO FindById(long Id);

        List<BookVO> FindAll();

        BookVO Update(BookVO book);

        void Delete(long Id);

        bool Exist(long id);
    }
}
