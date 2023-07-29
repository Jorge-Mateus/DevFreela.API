using DevFreela.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option, ExampleClass exampleClass)
        {
            exampleClass.Name = "Update at ProjectsController";
            _option = option.Value;
        }
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateModelProject updateModel)
        {
            if (updateModel.Description.Length > 50)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           
            return NoContent();
        }

        //api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createCommentModel)
        {
            return NoContent();
        }

        //api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent(); 
        }

        
    }
}
