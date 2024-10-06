using entities_library.comment;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.DTO.comment;


namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private readonly ILogger<PostController> _logger;
    public CommentController(ILogger<PostController> logger)
    {
        _logger = logger;
    }
    private static int nextId = 1; //esta variable debe irse cuando conectemos la bd para que los id los maneje la bd

    [HttpPost(Name = "CreatePost")]
    public IActionResult Post(CommentRequestDTO commentRequestDTO)
    {
        if (commentRequestDTO == null)
        {
            return BadRequest("Invalid data.");
        }

        //crear el comentario
        var newComment = new CommentRequestDTO
        {
            Id = nextId++,
            Text = commentRequestDTO.Text,
            PostId = commentRequestDTO.PostId,
        };

        

        
        return CreatedAtAction(nameof(Comment), new { id = newComment.Id }, newComment);
    }

    [HttpGet(Name = "GetAllComments")]
    public IActionResult GetAll()
    {


        return Ok(new List<CommentRequestDTO>());
    }

    [HttpGet("{id}", Name ="GetCommentById")]
    public IActionResult Get(int id)
    {
        return NotFound();
    }

}


