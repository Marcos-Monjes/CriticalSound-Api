namespace web_api.dto.DTO.comment
{
    public class CommentResponseDTO
    {
        public int Id { get; set; }//id del comentario
        public string Text { get; set; } = "";//contenido del mismo
        public string User { get; set; } = "";//quien lo hizo
        public string Date { get; set; } = "";//en que fecha
    }
}