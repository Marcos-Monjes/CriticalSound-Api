using dao_library.Interfaces;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.register;
using dao_library.Interfaces.login;
using entities_library.login;




namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]
public class RegisterController : ControllerBase
{
    private readonly ILogger<RegisterController> _logger;
    
    private readonly IDAOFactory daoFactory;
    public RegisterController(ILogger<RegisterController> logger, IDAOFactory daoFactory)
    {
        _logger = logger;
        this.daoFactory = daoFactory;
    }

    [HttpPost(Name = "CreateUser")]
    public async Task<IActionResult> Post(RegisterPostRequestDTO RegisterPostRequestDTO)
    {
        IDAOUser daoRegisterUser = daoFactory.CreateDAOUser();

        User? userExisting = await daoRegisterUser.Get(RegisterPostRequestDTO.userName, RegisterPostRequestDTO.password);
        
        if (userExisting == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "Usuario ya registrado."
            });
        }
        if(RegisterPostRequestDTO == null)
        {
            return BadRequest(new ErrorResponseDTO
            {
                success = false,
                message = "Datos ingresados erroneos"
            });
        }

        if(string.IsNullOrEmpty(RegisterPostRequestDTO.userName))
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


        return Ok(new RegisterPostResponseDTO
        {
            success= true,
            userName = RegisterPostRequestDTO.userName,
            birthdate= RegisterPostRequestDTO.birthdate,
            mail= RegisterPostRequestDTO.mail,
            
        });
    }
}

// return Ok(new LoginResponseDTO 
//             {
//                 success = true,
//                 message = "",
//                 id = user.Id,
//                 userName = user.userName,
//                 description = user.Description,
//                 urlAvatar = "",
//                 mail = user.Mail
//             });