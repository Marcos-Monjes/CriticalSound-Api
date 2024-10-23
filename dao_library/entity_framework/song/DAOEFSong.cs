using dao_library.Interfaces.song;
using entities_library.song;

namespace dao_library.entity_framework.song;

public class DAOEFSong : IDAOSong 
{
    private readonly ApplicationDbContext context;

    public DAOEFSong(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(Song song)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Song>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Song> GetById(long? id)
    {
        throw new NotImplementedException();
    }
    

    public Task Save(Song song)
    {
        throw new NotImplementedException();
    }
}