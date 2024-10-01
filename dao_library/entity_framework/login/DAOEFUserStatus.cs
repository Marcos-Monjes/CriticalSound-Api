using dao_library.Interfaces.login;
using entities_library.login;

namespace dao_library.entity_framework.login;

public class DAOEFUserStatus : IDAOUserStatus
{
    private readonly ApplicationDbContext context;

    public DAOEFUserStatus(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task<IEnumerable<UserStatus>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserStatus> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Save(UserStatus userStatus)
    {
        throw new NotImplementedException();
    }

        public Task Delete(UserStatus userStatus)
    {
        throw new NotImplementedException();
    }
}