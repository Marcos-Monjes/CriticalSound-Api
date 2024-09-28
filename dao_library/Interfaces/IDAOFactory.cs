using dao_library.Interfaces.login;
using dao_library.Interfaces.post;

namespace dao_library.Interfaces;

public interface IDAOFactory 
{
    IDAOUser CreateDAOUser();
    IDAOPerson CreateDAOPerson();
    IDAOUserBan CreateDAOUserBan();
    IDAOPost CreateDAOPost();
}