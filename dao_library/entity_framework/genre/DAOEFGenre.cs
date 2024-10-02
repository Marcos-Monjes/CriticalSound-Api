using dao_library.Interfaces.genre;
using entities_library.genre;

namespace dao_library.entity_framework.genre;

public class DAOEFGenre : IDAOGenre 
{
    private readonly ApplicationDbContext context;

    public DAOEFGenre(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(Genre genre)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Genre>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Genre> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(Genre genre)
    {
        throw new NotImplementedException();
    }
}