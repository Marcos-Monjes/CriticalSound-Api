using dao_library.Interfaces;
using dao_library.Interfaces.login;
using dao_library.entity_framework.login;
using dao_library.Interfaces.post;
using dao_library.entity_framework.post;
using dao_library.Interfaces.comment;
using dao_library.entity_framework.comment;
using dao_library.Interfaces.billboard;
using dao_library.entity_framework.billboard;
using dao_library.Interfaces.file_system;
using dao_library.entity_framework.file_system;
using dao_library.entity_framework.genre;
using dao_library.Interfaces.genre;


namespace dao_library.entity_framework;

public class DAOEFFactory : IDAOFactory
{
    private readonly ApplicationDbContext context;

    public DAOEFFactory(ApplicationDbContext context)
    {
        this.context = context;
    }

    public IDAOBillboard CreateDAOBillboard()
    {
        return new DAOEFBillboard(context);
    }

    public IDAOComment CreateDAOComment()
    {
        return new DAOEFComment(context);
    }

    public IDAOPerson CreateDAOPerson()
    {
        return new DAOEFPerson(context);
    }

    public IDAOPost CreateDAOPost()
    {
        return new DAOEFPost(context);
    }

    public IDAOUser CreateDAOUser()
    {
        return new DAOEFUser(context);
    }

    public IDAOUserBan CreateDAOUserBan()
    {
        return new DAOEFUserBan(context);
    }

    public IDAOUserStatus CreateDAOUserStatus()
    {
        return new DAOEFUserStatus(context);
    }

    public IDAOFileType CreateDAOFiletype()
    {
        return new DAOEFFileType(context);
    }
    public IDAOFilee CreateDAOFilee()
    {
        return new DAOEFFilee(context);
    }
    public IDAOGenre CreateDAOGenre()
    {
        return new DAOEFGenre(context);
    }

    public IDAOFileType CreateDAOFileType()
    {
        throw new NotImplementedException();
    }

    IDAOFilee IDAOFactory.CreateDAOFilee()
    {
        throw new NotImplementedException();
    }

    IDAOGenre IDAOFactory.CreateDAOGenre()
    {
        throw new NotImplementedException();
    }
}