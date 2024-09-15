using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.register;

// using web_api.helpers;   
using web_api.mock;

namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]
public class RegisterController : ControllerBase
{
    private readonly ILogger<RegisterController> _logger;
    
    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CreateRegister")]
    public IActionResult Post(RegisterPostRequestDTO RegisterPostRequestDTO)
    {
        if(RegisterPostRequestDTO == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "Datos ingresados erroneos"
            });
        }

        if(string.IsNullOrEmpty(RegisterPostRequestDTO.name))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El nombre es un dato obligatorio"
            });
        }

        if(string.IsNullOrEmpty(RegisterPostRequestDTO.username))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El nombre de usuario es un dato obligatorio"
            });
        }

        if(string.IsNullOrEmpty(RegisterPostRequestDTO.mail))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El correo electrónico es un dato obligatorio"
            });
        }

        if(RegisterPostRequestDTO.birthdate == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "La fecha de nacimiento es un dato obligatorio"
            });
        }

        if(string.IsNullOrEmpty(RegisterPostRequestDTO.password))
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "El password es un dato obligatorio"
            });
        }

        long id = UserMock.Instance.CreateUser(
            RegisterPostRequestDTO.name, 
            RegisterPostRequestDTO.username, 
            RegisterPostRequestDTO.mail, 
            RegisterPostRequestDTO.birthdate,
            RegisterPostRequestDTO.password);

        return Ok(new RegisterPostResponseDTO
        {
            id = id,
            name = RegisterPostRequestDTO.name,
            username = RegisterPostRequestDTO.username,
            mail = RegisterPostRequestDTO.mail
        });
    }
}