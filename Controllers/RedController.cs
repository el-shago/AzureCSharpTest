using Microsoft.AspNetCore.Mvc;

namespace RedesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedController : ControllerBase
    {
        // GET: api/Red
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, RedesAPI!" });
        }

        // GET: api/Red/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { message = $"You sent ID: {id}" });
        }

        // POST: api/Red
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", new { message = $"You posted: {value}" });
        }
    }
}
