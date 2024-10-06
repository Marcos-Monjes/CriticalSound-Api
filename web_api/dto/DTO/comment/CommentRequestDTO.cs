namespace web_api.dto.DTO.comment;

    public class CommentRequestDTO
    {
        public long Id { get; set; }//quien hace el comentario
        public string Text { get; set; } = "";//el comentario en si
        public long PostId { get; set; }//en que post estoy comentando
    }



