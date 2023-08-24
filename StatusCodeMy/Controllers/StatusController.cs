using Microsoft.AspNetCore.Mvc;
using StatusCodeMy.St;

namespace StatusCodeMy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : Controller
    {
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
       
        public ActionResult<Status>GetStatus(int id)
        {
            if(id == 0)
            { 
                return BadRequest();

            };
           
            return Ok();

        }

    }
}
