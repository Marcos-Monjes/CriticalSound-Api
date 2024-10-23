using entities_library.login;
using entities_library.comment;
using entities_library.reactions;
using entities_library.billboard;


namespace entities_library.song;

public class Song
{
    public long SongId { get; set; }
    public required string Title { get; set; } // titulo de la cancion artista o la banda y el nombre de la cancion
    public required string UrlImage { get; set; }  //averiguar como almacenar la url de una imagen
    public required string Description{ get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Reaction> Ractions { get; set; } = new List<Reaction>();

    public DateTime DateTime { get; set; }
    public required Billboard Billboard { get; set; } //necesita almacenar el genero, corroborar si la clase esta bien hecha
    public required User User { get; set; }

}