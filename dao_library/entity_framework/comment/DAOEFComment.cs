using dao_library.Interfaces.comment;
using entities_library.comment;

namespace dao_library.entity_framework.comment;

public class DAOEFComment : IDAOComment
{
    private readonly ApplicationDbContext context;

    public DAOEFComment(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task<IEnumerable<Comment>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Comment> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(Comment comment)
    {
        throw new NotImplementedException();
    }
    
    public Task Delete(Comment comment)
    {
        throw new NotImplementedException();
    }

}