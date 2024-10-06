namespace web_api.dto.DTO.comment
{
    public class CommentResponseDTO
    {
        public long Id { get; set; }//id del comentario
        public long PostI { get; set;}//en que post se hizo el comentario
        public string Text { get; set; } = "";//contenido del mismo
        public string User { get; set; } = "";//quien lo hizo
        public string Date { get; set; } = "";//en que fecha
    }
}