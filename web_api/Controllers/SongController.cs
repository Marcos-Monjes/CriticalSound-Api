using dao_library.Interfaces;
using dao_library.Interfaces.song;
using entities_library.song;
using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.DTO.song;


namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
        private readonly ILogger<SongController> _logger;

        private readonly IDAOFactory daoFactory;
        public SongController(ILogger<SongController> logger, IDAOFactory daoFactory)
        {
            _logger = logger;
            this.daoFactory = daoFactory;
        }

        [HttpPost(Name = "CreateSong")]
        public async Task<IActionResult> Post(SongRequestDTO songRequestDTO)
        {
            IDAOSong daoSongAdd = daoFactory.CreateDAOSong(); //usamos la interfaz para crear un song/post
            Song? song = await daoSongAdd.Get(
                songRequestDTO.title,
                songRequestDTO.genre);

            // if (songRequestDTO == null)
            if (song != null && song.Title == songRequestDTO.title)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "There is already a post with that title." //ya hay un post con ese titulo
                });
            }

            if(songRequestDTO == null)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false, 
                    message = "The fields must be completed." //Se deben completar los campos.
                });
            }

            if(string.IsNullOrEmpty(songRequestDTO.title))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "The title is a required field." //El titulo es un campo obligatorio.
                });
            }

            if(string.IsNullOrEmpty(songRequestDTO.genre))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "The type of genre is a required field." //El tipo de genero es un campo obligatorio.
                });
            }

            if(string.IsNullOrEmpty(songRequestDTO.urlImage))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "You must enter an image." //Debe ingresar una imagen.
                }); 
            }

            if(string.IsNullOrEmpty(songRequestDTO.description))
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success = false,
                    message = "You must enter a description." //Debe ingresar una descripcion.
                });
            }

            IDAOSong daoSong = daoFactory.CreateDAOSong();
            Song? existingSong = await daoSong.GetByTitle(songRequestDTO.title);

            if(existingSong != null)
            {
                return BadRequest(new ErrorResponseDTO
                {
                    success=false,
                    message = "The title of the post already exists." //El titulo del post ya existe.
                });
            }

            //crear el post
            Song newSong = new Song
            {
                Title = songRequestDTO.title,
                Genre = songRequestDTO.genre,
                UrlImage = songRequestDTO.urlImage,
                Description = songRequestDTO.description
            };
            await daoSong.Save(newSong);

            return Ok(new SongResponseDTO
            {
                success = true,
                message = "El post fue creado exitosamente.",
                id = newSong.Id,
                title = newSong.Title,
                genre = newSong.Genre,
                urlImage = newSong.UrlImage,
                description = newSong.Description
            });   
        }


        [HttpGet(Name = "GetAllSongs")]
        public async Task<IActionResult> GetAll(string? query, int page = 1, int pageSize = 10)
        {
            IDAOSong daoSong = daoFactory.CreateDAOSong();
            var (songs, totalRecords) = await daoSong.GetAll(query, page, pageSize);
            if (totalRecords == 0)
            {
                return Ok("No se encontraron canciones disponibles");
            }
            var songResponseList = songs.Select(song => new SongResponseDTO
            {
                success = true,
                message = "Canciones obtenidas correctamente.",
                id = song.Id,
                title = song.Title,
                genre = song.Genre,
                urlImage = song.UrlImage,
                description = song.Description
            }).ToList();

            return Ok(new {
                TotalRecords = totalRecords,
                Songs = songResponseList
            });
            
        }

        [HttpGet("{id}", Name ="GetSongById")]
        public async Task<IActionResult> Get(long id)
        {
            IDAOSong daoSong = daoFactory.CreateDAOSong();
            Song? song = await daoSong.GetById(id);
            if (song == null)
            {   
                return NotFound("El post no se encuentra.");          
            }
            return Ok(new SongResponseDTO
            {
                success = true,
                message = "Post encontrado.",
                id = song.Id,
                title = song.Title,
                genre = song.Genre,
                urlImage = song.UrlImage,
                description = song.Description
            });
        }
    }
}


