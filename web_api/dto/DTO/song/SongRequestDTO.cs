using web_api.dto.common;

namespace web_api.dto.DTO.song;

    public class SongRequestDTO : RequestDTO
    {
        public string title { get; set; } = "";//titulo del post
        public string genre { get; set; } = "";//genero
        public string urlImage { get; set; } = "";//url de la imagen
        public string description { get; set; } = "";//descripcn
        
    }



