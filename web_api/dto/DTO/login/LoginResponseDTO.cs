using web_api.dto.common;

namespace web_api.dto.login;

public class LoginResponseDTO : ResponseDTO
{
    public long id { get; set; }
    public string userName { get; set; } = "";
    public string description { get; set; } = "";
    public string urlAvatar { get; set; } = "";
    public string mail { get; set; } = "";
}


// using web_api.dto.common;

// namespace web_api.dto.login;

// public class LoginResponseDTO : ResponseDTO
// {
//     public long id { get; set; }
//     public string name { get; set; } = "";
//     public string username{ get; set; } = "";
//     public string urlAvatar { get; set; } = "";
//     public string mail { get; set; } = "";
// }