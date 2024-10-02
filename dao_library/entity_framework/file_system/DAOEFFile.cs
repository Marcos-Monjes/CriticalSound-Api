using dao_library.Interfaces.file_system;
using entities_library.file_system;

namespace dao_library.entity_framework.file_system;

public class DAOEFFile : IDAOFile
{
    private readonly ApplicationDbContext context;

    public DAOEFFile(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(entities_library.file_system.File file)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<entities_library.file_system.File>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<entities_library.file_system.File> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(entities_library.file_system.File file)
    {
        throw new NotImplementedException();
    }
}