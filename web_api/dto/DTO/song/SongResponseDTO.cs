using web_api.dto.common;

namespace web_api.dto.DTO.song
{
    public class SongResponseDTO : ResponseDTO
    {
        public long id { get; set; }//id del post
        public string title { get; set; } = "";//titulo
        public string genre { get; set; } = "";//genero
        public string urlImage { get; set; } = "";//url de la imagen
        public string description { get; set; } = "";//descripcion
        
    }
}
