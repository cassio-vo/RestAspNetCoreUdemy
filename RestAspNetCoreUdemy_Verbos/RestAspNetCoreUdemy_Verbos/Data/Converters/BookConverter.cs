using RestAspNetCoreUdemy_Verbos.Data.Converter;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Data.Converters
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null)
                return null;
            else
                return new Book {
                    Id = origin.Id,
                    Author = origin.Author,
                    LaunchDate = origin.LaunchDate,
                    Price = origin.Price,
                    Title = origin.Title
                };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null)
                return null;
            else
                return new BookVO
                {
                    Id = origin.Id,
                    Author = origin.Author,
                    LaunchDate = origin.LaunchDate,
                    Price = origin.Price,
                    Title = origin.Title
                };
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
