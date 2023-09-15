using Microsoft.AspNetCore.Mvc;
using SimpleVideoGameLibrary.Shared;

namespace SimpleVideoGameLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        public async Task <ActionResult<List<VideoGame>>> GetAllVideoGames()
        {
            var list = new List<VideoGame>
            {
                new VideoGame {id = 1, Title = "Tetris", Publisher = "Nintendo", ReleaseYear = 1989, Comments = "It's Ok"},
                new VideoGame {id = 1, Title = "Pong", Publisher = "Atari", ReleaseYear = 1972, Comments = "Is the best"}
            };
            return Ok(list);
        }
    }
}
