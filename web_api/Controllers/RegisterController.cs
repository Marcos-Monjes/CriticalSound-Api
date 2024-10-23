using dao_library.Interfaces;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.register;
using dao_library.Interfaces.login;
using entities_library.login;

namespace web_api.Controllers
{
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
        public async Task<IActionResult> Post(RegisterPostRequestDTO registerPostRequestDTO)
        {
            if (registerPostRequestDTO == null)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "Datos ingresados erróneos"
                });
            }

            if (string.IsNullOrEmpty(registerPostRequestDTO.userName))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "El nombre de usuario es un dato obligatorio"
                });
            }

            if (string.IsNullOrEmpty(registerPostRequestDTO.mail))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "El correo electrónico es un dato obligatorio"
                });
            }

            if (registerPostRequestDTO.birthdate == null)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "La fecha de nacimiento es un dato obligatorio"
                });
            }

            if (string.IsNullOrEmpty(registerPostRequestDTO.password))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "El password es un dato obligatorio"
                });
            }

            IDAOUser daoRegisterUser = daoFactory.CreateDAOUser();

            User? existingUser = await daoRegisterUser.GetByUsername(registerPostRequestDTO.userName);
            if (existingUser != null)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "El nombre de usuario ya está registrado"
                });
            }

            User newUser = new User
            {
                userName = registerPostRequestDTO.userName,
                Mail = registerPostRequestDTO.mail,
                Birthdate = registerPostRequestDTO.birthdate,
                password = registerPostRequestDTO.password

            };

            // Encriptar el password antes de guardar
            newUser.Encrypt(registerPostRequestDTO.password);

            // Guardar el nuevo usuario en la base de datos
            await daoRegisterUser.Save(newUser);

            return Ok(new RegisterPostResponseDTO
            {
                success = true,
                message = "Nuevo usuario registrado",
                id = newUser.Id,
                userName = newUser.userName,
                birthdate = newUser.Birthdate,
                password = newUser.password,
                mail = newUser.Mail,
                userStatus = newUser.userStatus.ToString() 
            }
            );
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
}
