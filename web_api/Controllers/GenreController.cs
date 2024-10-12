using Microsoft.AspNetCore.Mvc;
using web_api.dto.genre;
using dao_library.Interfaces;
using dao_library.Interfaces.genre;
using entities_library.genre;
using web_api.dto.login;


namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : ControllerBase
{
    private readonly ILogger<GenreController> _logger;
    private readonly IDAOFactory daoFactory;
    public GenreController(ILogger<GenreController> logger, IDAOFactory daoFactory)
    {
        _logger = logger;
        this.daoFactory = daoFactory;
    }

    [HttpPost(Name = "CreateGenre")]
    public async Task <ActionResult> Post(GenreResquestDTO genreResquestDTO)
    {
        IDAOGenre daoGenre = daoFactory.CreateDAOGenre();
        Genre? genre = await daoGenre.GetByType(genreResquestDTO.genreType);
        
        if (genre != null && genre.genreType == genreResquestDTO.genreType)
        {
            return BadRequest("Genero ya registrado");
        }

        Genre newGenre = new Genre
            {   
                genreType = genreResquestDTO.genreType,
                description = genreResquestDTO.description
            };

        await daoGenre.Save(newGenre);
    
        
        return Ok(new GenreResponseDTO
        {
            success = true,
            message = "",
            id = newGenre.id,
            genreType = newGenre.genreType,
            description = newGenre.description
        });
    }

    // [HttpGet(Name = "GetAllPosts")]
    // public IActionResult GetAll()
    // {
    //     //aca añadir lo de la base de datos despues

    //     return Ok(new List<PostResponseDTO>());// cuando la bd esté aca tiene que devolver los posts que esten en ella
    // }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        IDAOGenre daoGenre = daoFactory.CreateDAOGenre();
        Genre? genre = await daoGenre.GetById(id);
        if (genre == null)
        {
            return BadRequest("Género no encontrado");
        }

        return Ok(genre);
}}




