
using web_api.dto.common;

namespace web_api.dto.comment;

public class CommentRequestDTO : RequestDTO
{
    public long id { get; set; },    
    public string text { get; set; },

    public string username { get; set; },

    public DateTime date { get; set; },

    public string reaction { get; set; }
}