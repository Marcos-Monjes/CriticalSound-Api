using entities_library.song;

namespace dao_library.Interfaces.song;

public interface IDAOSong
{
    Task<IEnumerable<Song>> GetAll();
    Task<Song?> GetById(long? id);

    //En nuestro caso necesitamos devolver lo comentado abajo por lo de billboard.
    // Task<Post> GetMostLiked(list);
    // Task<Post> GetMostCritized(list);
    Task Save(Song song);
    
    //NO PROGRAMAR
    Task Delete(Song song);
}