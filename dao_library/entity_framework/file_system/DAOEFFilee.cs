using dao_library.Interfaces.file_system;
using entities_library.file_system;

namespace dao_library.entity_framework.file_system;

public class DAOEFFilee : IDAOFilee
{
    private readonly ApplicationDbContext context;

    public DAOEFFilee(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(Filee filee)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Filee>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Filee> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(Filee filee)
    {
        throw new NotImplementedException();
    }
}