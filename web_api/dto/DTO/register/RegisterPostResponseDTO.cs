
using web_api.dto.common;

namespace web_api.dto.register;

public class RegisterPostResponseDTO : ResponseDTO
{
    public long id { get; set; }
    public string name { get; set; } = "";
    public string username { get; set; } = "";
    public string mail { get; set; } = "";
}