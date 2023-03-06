using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using person.DDD.API.ApplicationServices;
using person.DDD.API.Commands;

namespace person.DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonServices personServices;
        public PersonController(PersonServices personServices) 
        {
            this.personServices = personServices;
        }
        [HttpPost]
        public async Task<IActionResult>AddPerson(CreatePersonCommand createPersonCommand)
        {
            await personServices.HandleCommand(createPersonCommand);
            return Ok(createPersonCommand);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var response = await personServices.GetPerson(id);
            return Ok(response);
        }
    }
}
