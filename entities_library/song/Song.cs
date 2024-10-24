using System.ComponentModel.DataAnnotations; // Asegúrate de incluir esto
using System.ComponentModel.DataAnnotations.Schema; // Asegúrate de incluir esto
using entities_library.login;
using entities_library.comment;
using entities_library.reactions;


namespace entities_library.song;

public class Song
{
    [Key] // Indica que esta propiedad es la clave primaria
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Configura la propiedad para que sea AUTO_INCREMENT
    public long Id { get; set; }

    public required string Title { get; set; } // titulo de la cancion artista o la banda y el nombre de la cancion
    public required string Genre { get; set; } //genero de la cancion
    public required string UrlImage { get; set; }  //averiguar como almacenar la url de una imagen
    public required string Description{ get; set; }
    public DateTime DateTime { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Reaction> Ractions { get; set; } = new List<Reaction>();

    
    // public required User User { get; set; }
}