using Microsoft.AspNetCore.Mvc;
using RestAspNetCoreUdemy_Verbos.Business;
using RestAspNetCoreUdemy_Verbos.Data.VO;

namespace RestAspNetCoreUdemy_Verbos.Controllers
{
    [Route("api/[controller]/v{version:apiversion}")]
    [ApiVersion("1")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personService)
        {
            _personBusiness = personService;
        }

        // GET: api/Person
        [HttpGet(Name = "GetAllPersons")]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "GetPersons")]
        public IActionResult Get(int id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // POST: api/Person
        [HttpPost(Name = "CreatePerson")]
        public IActionResult Post([FromBody] PersonVO person)
        {
            if (person == null)
                return NotFound();

            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT: api/Person/5
        [HttpPut("{id}", Name = "UpdatePerson")]
        public IActionResult Put(int id, [FromBody] PersonVO person)
        {
            if (person == null)
                return NotFound();

            return new ObjectResult(_personBusiness.Update(person));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeletePerson")]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
