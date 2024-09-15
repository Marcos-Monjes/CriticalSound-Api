// using web_api.dto.common;
// using web_api.dto.login;
// using web_api.mock;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.post;
using entities_library.post;

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
    private static int nextId = 1;

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
}


