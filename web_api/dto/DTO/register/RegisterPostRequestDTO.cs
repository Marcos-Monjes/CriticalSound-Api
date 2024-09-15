
using web_api.dto.common;

namespace web_api.dto.register;

public class RegisterPostRequestDTO : RequestDTO
{
    public string name { get; set; } = "";
    public string username { get; set; } = "";
    public DateTime? birthdate { get; set; }
    public string mail { get; set; } = "";
    public string password { get; set; } = "";
}   