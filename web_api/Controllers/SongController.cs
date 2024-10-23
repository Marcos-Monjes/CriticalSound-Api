using Microsoft.AspNetCore.Mvc;
using web_api.dto.DTO.song;


namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class SongController : ControllerBase
{
    private readonly ILogger<SongController> _logger;
    public SongController(ILogger<SongController> logger)
    {
        _logger = logger;
    }
    private static int nextId = 1; //esta variable debe irse cuando conectemos la bd para que los id los maneje la bd

    [HttpPost(Name = "CreatePost")]
    public IActionResult Post(SongRequestDTO songRequestDTO)
    {
        if (songRequestDTO == null)
        {
            return BadRequest("Invalid data.");
        }

        //crear el post
        var newSong = new SongResponseDTO
        {
            id = nextId++,
            title = songRequestDTO.title,
            genre = songRequestDTO.genre,
            urlImage = songRequestDTO.urlImage,
            description = songRequestDTO.description
        };

        //codigo para guardar el post en la base de datos puede ir aca?

        //201 Created con el post creado
        return CreatedAtAction(nameof(Post), new { id = newSong.id }, newSong);
    }

    [HttpGet(Name = "GetAllSongs")]
    public IActionResult GetAll()
    {
        //aca añadir lo de la base de datos despues

        return Ok(new List<SongResponseDTO>());// cuando la bd esté aca tiene que devolver los posts que esten en ella
    }

    [HttpGet("{id}", Name ="GetSongById")]
    public IActionResult Get(int id)
    {
        return NotFound();// esto tmb cuando la bd esté, el codigo este cambia.
    }

}


