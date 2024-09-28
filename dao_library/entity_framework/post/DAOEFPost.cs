using dao_library.Interfaces.post;
using entities_library.post;

namespace dao_library.entity_framework.post;

public class DAOEFPost : IDAOPost 
{
    private readonly ApplicationDbContext context;

    public DAOEFPost(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(Post post)
    {
        throw new NotImplementedException();
    }
}