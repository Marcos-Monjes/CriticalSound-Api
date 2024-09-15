namespace web_api.dto.post
{
    public class PostResponseDTO
    {
        public int Id { get; set; }//id del post
        public string Title { get; set; } = "";//titulo
        public string Genre { get; set; } = "";//genero
        public string UrlImage { get; set; } = "";//url de la imagen
        public string Description { get; set; } = "";//descripcion
        
    }
}
