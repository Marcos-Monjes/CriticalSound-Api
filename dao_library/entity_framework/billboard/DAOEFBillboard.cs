using dao_library.Interfaces.billboard;
using entities_library.billboard;

namespace dao_library.entity_framework.billboard;

public class DAOEFBillboard : IDAOBillboard
{
    private readonly ApplicationDbContext context;

    public DAOEFBillboard(ApplicationDbContext context)
    {
        this.context = context;
    }
    public Task<IEnumerable<Billboard>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Billboard> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(Billboard billboard)
    {
        throw new NotImplementedException();
    }

        public Task Delete(Billboard billboard)
    {
        throw new NotImplementedException();
    }
}