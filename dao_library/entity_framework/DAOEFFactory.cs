using dao_library.Interfaces;
using dao_library.Interfaces.login;
using dao_library.entity_framework.login;
using dao_library.Interfaces.song;
using dao_library.entity_framework.song;
using dao_library.Interfaces.comment;
using dao_library.entity_framework.comment;
using dao_library.Interfaces.file_system;
using dao_library.entity_framework.file_system;
using dao_library.entity_framework.genre;
using dao_library.Interfaces.genre;
using dao_library.Interfaces.reaction;


namespace dao_library.entity_framework;

public class DAOEFFactory : IDAOFactory
{
    private readonly ApplicationDbContext context;

    public DAOEFFactory(ApplicationDbContext context)
    {
        this.context = context;
    }
    public IDAOSong CreateDAOSong()
    {
        return new DAOEFSong(context);
    }

    public IDAOComment CreateDAOComment()
    {
        return new DAOEFComment(context);
    }

    public IDAOPerson CreateDAOPerson()
    {
        return new DAOEFPerson(context);
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

    public IDAOFile CreateDAOFile()
    {
        return new DAOEFFile(context);
    }
    public IDAOGenre CreateDAOGenre()
    {
        return new DAOEFGenre(context);
    }

    public IDAOFileType CreateDAOFileType()
    {
        return new DAOEFFileType(context);
    }

    public IDAOReaction CreateDAOReaction()
    {
        throw new NotImplementedException();
    }

    public IDAOReactionType CreateDAOReactionType()
    {
        throw new NotImplementedException();
    }


}