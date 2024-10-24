using dao_library.Interfaces.comment;
using dao_library.Interfaces.login;
using dao_library.Interfaces.song;
using dao_library.Interfaces.file_system;
using dao_library.Interfaces.genre;
using dao_library.Interfaces.reaction;


namespace dao_library.Interfaces;

public interface IDAOFactory 
{
    IDAOUser CreateDAOUser();
    IDAOPerson CreateDAOPerson();
    IDAOUserBan CreateDAOUserBan();
    IDAOUserStatus CreateDAOUserStatus();
    IDAOSong CreateDAOSong();
    IDAOComment CreateDAOComment();
    IDAOFileType CreateDAOFileType();
    IDAOGenre CreateDAOGenre();
    IDAOFile CreateDAOFile();
    IDAOReaction CreateDAOReaction();
    IDAOReactionType CreateDAOReactionType();
}