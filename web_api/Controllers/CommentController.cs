
//ejemplo provisorio cortesia de rulo
using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.comment;
using web_api.mock;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private readonly ILogger<CommentController> _logger;

    public CommentController(ILogger<CommentController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CreateComment")]
    public IActionResult Post(CommentPostRequestDTO commentPostRequestDTO)
    {
        // Validación: Verifica si el cuerpo de la solicitud es nulo
        if (commentPostRequestDTO == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "Datos del comentario incorrectos"
            });
        }

        // Validación: El texto del comentario es obligatorio
        if (string.IsNullOrEmpty(commentPostRequestDTO.content))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El contenido del comentario es obligatorio"
            });
        }

        // Validación: El ID del usuario que escribe el comentario es obligatorio
        if (commentPostRequestDTO.userId <= 0)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El ID del usuario es obligatorio"
            });
        }

        // Validación: El ID del post al que pertenece el comentario es obligatorio
        if (commentPostRequestDTO.postId <= 0)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El ID del post es obligatorio"
            });
        }

        // Simulación de la creación del comentario (UserMock sería reemplazado por una lógica real de base de datos)
        long commentId = CommentMock.Instance.CreateComment(
            commentPostRequestDTO.content,
            commentPostRequestDTO.userId,
            commentPostRequestDTO.postId
        );

        // Respuesta exitosa: Devuelve los datos del comentario recién creado
        return Ok(new CommentPostResponseDTO
        {
            id = commentId,
            content = commentPostRequestDTO.content,
            userId = commentPostRequestDTO.userId,
            postId = commentPostRequestDTO.postId,
            createdAt = DateTime.Now // Suponiendo que la fecha de creación es el momento actual
        });
    }

    // Aquí podrías agregar otros métodos como:
    // [HttpGet] para obtener comentarios
    // [HttpDelete] para eliminar comentarios
    // [HttpPut] para actualizar un comentario
}
