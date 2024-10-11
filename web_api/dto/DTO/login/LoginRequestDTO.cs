
using web_api.dto.common;

namespace web_api.dto.login;

public class LoginRequestDTO : RequestDTO
{
    public string userName { get; set; } = "";

    public string password { get; set; } = "";
}