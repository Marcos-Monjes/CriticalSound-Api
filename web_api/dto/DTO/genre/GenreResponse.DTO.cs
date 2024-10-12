
using web_api.dto.common;

namespace web_api.dto.login;

public class GenreResponseDTO : ResponseDTO
{
    public long id { get; set; }

    public string genreType { get; set; } = "";

    public string description { get; set; } = "";
}