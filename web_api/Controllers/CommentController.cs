
//ejemplo provisorio cortesia de rulo
using Microsoft.AspNetCore.Mvc;
using web_api.dto.comment;
using web_api.dto.common;
// using web_api.dto.comment;
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
    public IActionResult Post(CommentRequestDTO commentRequestDTO)
    {
        // Validación: Verifica si el cuerpo de la solicitud es nulo
        if (commentRequestDTO == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "Datos del comentario incorrectos"
            });
        }

        // Validación: El texto del comentario es obligatorio
        if (string.IsNullOrEmpty(CommentRequestDTO.text))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El contenido del comentario es obligatorio"
            });
        }

        // Validación: El ID del usuario que escribe el comentario es obligatorio
        if (CommentRequestDTO.id <= 0)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El ID del usuario es obligatorio"
            });
        }

        // Validación: El ID del post al que pertenece el comentario es obligatorio
        if (CommentRequestDTO.postId <= 0)
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
        return Ok(new CommentResponseDTO
        {
            id = commentId,
            text = CommentRequestDTO.text,
            userId = CommentRequestDTO.userId,
            postId = CommentRequestDTO.postId,
            createdAt = DateTime.Now // Suponiendo que la fecha de creación es el momento actual
        });
    }

    // Aquí podrías agregar otros métodos como:
    // [HttpGet] para obtener comentarios
    // [HttpDelete] para eliminar comentarios
    // [HttpPut] para actualizar un comentario
}
