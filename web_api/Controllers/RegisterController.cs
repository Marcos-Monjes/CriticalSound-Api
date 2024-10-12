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

        User? user = await daoRegisterUser.Get(
        RegisterPostRequestDTO.userName, 
        RegisterPostRequestDTO.password);
        
        if (user!= null && user.userName == RegisterPostRequestDTO.userName)
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
        
        User newUser = new User
        {
            userName = RegisterPostRequestDTO.userName,  
            Mail = RegisterPostRequestDTO.mail,          
            Birthdate = RegisterPostRequestDTO.birthdate    
        };

        await daoRegisterUser.Save(newUser);

        return Ok(new RegisterPostResponseDTO
        {
            success= true,
            message="Nuevo usuario registrado",
            id= newUser.Id,
            userName = newUser.userName,
            birthdate= newUser.Birthdate,
            mail= newUser.Mail,
            password=newUser.password
            
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        IDAOUser daoRegisterUser = daoFactory.CreateDAOUser();
        User? user = await daoRegisterUser.GetById(id);
        if (user == null)
        {
            return BadRequest("Usuario no encontrado");
        }

        return Ok(user);
}
}
