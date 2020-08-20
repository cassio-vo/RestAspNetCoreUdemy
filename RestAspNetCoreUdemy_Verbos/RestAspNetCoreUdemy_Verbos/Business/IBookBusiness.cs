using RestAspNetCoreUdemy_Verbos.Model;
using System.Collections.Generic;

namespace RestAspNetCoreUdemy_Verbos.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book FindById(long Id);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long Id);

        bool Exist(long id);
    }
}
