using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAspNetCoreUdemy_Verbos.Business;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.Model;

namespace RestAspNetCoreUdemy_Verbos.Controllers
{
    [Route("api/[controller]/v{version:apiversion}")]
    [ApiVersion("1")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookBusiness _bookBusiness;

        public BookController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        // GET: api/Books
        [HttpGet(Name = "GetBook")]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "GetBookById")]
        public IActionResult Get(int id)
        {
            return Ok(_bookBusiness.FindById(id));
        }

        // POST: api/Books
        [HttpPost( Name = "CreateBook")]
        public IActionResult Post([FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Create(book));
        }

        // PUT: api/Books/5
        [HttpPut("{id}", Name = "UpdateBook")]
        public IActionResult Put(int id, [FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Update(book));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteBook")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
