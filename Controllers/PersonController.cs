 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Problem1808.Validators;
using Problem1808.Models;

namespace Problem1808.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
       private readonly PersonValidator _validator;
        public PersonController(PersonValidator validator)
        {
            _validator = validator;
        }
        [HttpPost]
        public IActionResult CreatePerson([FromBody] PersonModel person)
        {
            var validationResult = _validator.Validate(person);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            // If the model is valid, you can proceed with further processing (e.g., saving to a database)
            return Ok("Person created successfully.");
        }
    }
}
