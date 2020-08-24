using RestAspNetCoreUdemy_Verbos.Data.Converters;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.Model;
using RestAspNetCoreUdemy_Verbos.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Business.Implmentations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(book)));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Update(BookVO book)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(book)));
        }
    }
}
