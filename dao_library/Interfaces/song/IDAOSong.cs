using entities_library.song;

namespace dao_library.Interfaces.song;

public interface IDAOSong
{
    // Task<IEnumerable<Song>> GetAll();

    Task<(IEnumerable<Song>, int)> GetAll(
        string? query,
        int page,
        int pageSize
    );
    Task<Song?> Get(string title, string genre);
    Task<Song?> GetById(long? id);

    Task<Song?> GetByTitle(string title);

    //En nuestro caso necesitamos devolver lo comentado abajo por lo de billboard.
    // Task<Post> GetMostLiked(list);
    // Task<Post> GetMostCritized(list);
    Task Save(Song song);
    
    //NO PROGRAMAR
    Task Delete(Song song);
}