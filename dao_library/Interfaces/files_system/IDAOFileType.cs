using entities_library.file_system;

namespace dao_library.Interfaces.file_system;
public interface IDAOFileType
{
    Task<IEnumerable<FileType>> GetAll();   // Devuelve una lista de FileTypes
    Task<FileType> GetById(long id);        // Devuelve un FileType por ID
    Task Save(FileType fileType);           // Guarda un FileType
    Task Delete(FileType fileType);         // Elimina un FileType (si fuera necesario implementarlo)
}
