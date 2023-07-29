using DevFreela.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersControllers : ControllerBase
    {
        public UsersControllers(ExampleClass exampleClass)
        {

        }
        //api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { Id = 1 }, createUserModel);
        }

        //[HttpPut("{id}")]
        /* public IActionResult Put(int id, [FromBody] CreateUserModel createUserModel)
         {
             return CreatedAtAction(nameof(GetById), new { Id = 1 }, createUserModel);
         }*/

        //api/user/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
