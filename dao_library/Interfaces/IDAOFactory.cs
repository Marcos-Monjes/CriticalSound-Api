using dao_library.Interfaces.billboard;
using dao_library.Interfaces.comment;
using dao_library.Interfaces.login;
using dao_library.Interfaces.post;
using dao_library.Interfaces.file_system;
using dao_library.Interfaces.genre;


namespace dao_library.Interfaces;

public interface IDAOFactory 
{
    IDAOUser CreateDAOUser();
    IDAOPerson CreateDAOPerson();
    IDAOUserBan CreateDAOUserBan();
    IDAOUserStatus CreateDAOUserStatus();
    IDAOPost CreateDAOPost();
    IDAOComment CreateDAOComment();
    IDAOBillboard CreateDAOBillboard();
    IDAOFileType CreateDAOFileType();
    IDAOFilee CreateDAOFilee();
    IDAOGenre CreateDAOGenre();


}