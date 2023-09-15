using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SimpleVideoGameLibrary.Shared;

namespace SimpleVideoGameLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AthensCityController : ControllerBase
    {
        public async Task<ActionResult<List<AthensCity>>> GetAllAthensCities()
        {
            var list = new List<AthensCity> {
                new AthensCity {id = 1 , PlaceName = "Athens", sights = "plaka", DistanceFromTheMetro = 10, Comments = "nice"},
                new AthensCity {id = 2 , PlaceName = "Athens2", sights = "plaka2", DistanceFromTheMetro = 102, Comments = "nice2"}
            };

            return Ok(list);
    }

    }
}
