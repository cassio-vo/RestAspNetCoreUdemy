using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using RestAspNetCoreUdemy_Verbos.Business;
using RestAspNetCoreUdemy_Verbos.Data.VO;
using RestAspNetCoreUdemy_Verbos.HATEOAS;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNetCoreUdemy_Verbos.Controllers
{
    [Route("api/[controller]/v{version:apiversion}")]
    [ApiVersion("1")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookBusiness _bookBusiness;
        private readonly LinkGenerator _linkGenerator;

        public BookController(IBookBusiness bookBusiness, LinkGenerator generator)
        {
            _bookBusiness = bookBusiness;
            _linkGenerator = generator;
        }

        // GET: api/Books
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(List<BookVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll().Select(x => (BookVO)GetUrl.GerarLinks(
                x,
                nameof(Get),
                this.HttpContext, _linkGenerator)));
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(BookVO))]
        public IActionResult GetBook(int id)
        {
            return Ok(GetUrl.GerarLinks(
                _bookBusiness.FindById(id),
                nameof(GetBook), 
                this.HttpContext, _linkGenerator));
        }

        // POST: api/Books
        [HttpPost( Name = "CreateBook")]
        [SwaggerResponse(200, Type = typeof(BookVO))]
        public IActionResult Post([FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Create(book));
        }

        // PUT: api/Books/5
        [HttpPut("{id}", Name = "UpdateBook")]
        [SwaggerResponse(200, Type = typeof(BookVO))]
        public IActionResult Put(int id, [FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Update(book));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteBook")]
        [SwaggerResponse(204)]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
