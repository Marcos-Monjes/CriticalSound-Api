using entities_library.login;

namespace dao_library.Interfaces.login;

public interface IDAOUserStatus
{
    Task<IEnumerable<UserStatus>> GetAll();
    Task<UserStatus> GetById(long id);
    Task Save(UserStatus userStatus);
    
    //NO PROGRAMAR
    Task Delete(UserStatus userStatus);
}