using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/books/{bookId:guid}/characters")]
    [ApiController]
    public class BookCharactersController : ControllerBase
    {
        
    }
}