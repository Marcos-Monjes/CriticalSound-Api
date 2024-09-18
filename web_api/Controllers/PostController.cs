using Microsoft.AspNetCore.Mvc;
using web_api.dto.DTO.post;


namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly ILogger<PostController> _logger;
    public PostController(ILogger<PostController> logger)
    {
        _logger = logger;
    }
    private static int nextId = 1; //esta variable debe irse cuando conectemos la bd para que los id los maneje la bd

    [HttpPost(Name = "CreatePost")]
    public IActionResult Post(PostRequestDTO postRequestDTO)
    {
        if (postRequestDTO == null)
        {
            return BadRequest("Invalid data.");
        }

        //crear el post
        var newPost = new PostResponseDTO
        {
            Id = nextId++,
            Title = postRequestDTO.Title,
            Genre = postRequestDTO.Genre,
            UrlImage = postRequestDTO.UrlImage,
            Description = postRequestDTO.Description
        };

        //codigo para guardar el post en la base de datos puede ir aca?

        //201 Created con el post creado
        return CreatedAtAction(nameof(Post), new { id = newPost.Id }, newPost);
    }

    [HttpGet(Name = "GetAllPosts")]
    public IActionResult GetAll()
    {
        //aca añadir lo de la base de datos despues

        return Ok(new List<PostResponseDTO>());// cuando la bd esté aca tiene que devolver los posts que esten en ella
    }

    [HttpGet("{id}", Name ="GetPostById")]
    public IActionResult Get(int id)
    {
        return NotFound();// esto tmb cuando la bd esté, el codigo este cambia.
    }

}


