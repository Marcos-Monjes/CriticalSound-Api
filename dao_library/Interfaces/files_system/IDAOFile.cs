using entities_library.file_system;

namespace dao_library.Interfaces.file_system;

public interface IDAOFile
{
    Task<IEnumerable<entities_library.file_system.File>> GetAll();   // Devuelve una lista de FileTypes
    Task<entities_library.file_system.File> GetById(long id);        // Devuelve un FileType por ID
    Task Save(entities_library.file_system.File file);           // Guarda un FileType
    Task Delete(entities_library.file_system.File file);         // Elimina un FileType (si fuera necesario implementarlo)
}
