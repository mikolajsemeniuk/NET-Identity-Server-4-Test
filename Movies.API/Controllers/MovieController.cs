using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new { Message = "works" });
        }
    }
}