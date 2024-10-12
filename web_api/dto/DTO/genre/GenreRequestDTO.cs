
using web_api.dto.common;

namespace web_api.dto.genre;

public class GenreResquestDTO : RequestDTO
{
    public string genreType { get; set; } = "";

    public string description { get; set; } = "";
}