using entities_library.file_system;

namespace dao_library.Interfaces.file_system;

public interface IDAOFilee
{
    Task<IEnumerable<Filee>> GetAll();   // Devuelve una lista de FileTypes
    Task<Filee> GetById(long id);        // Devuelve un FileType por ID
    Task Save(Filee filee);           // Guarda un FileType
    Task Delete(Filee filee);         // Elimina un FileType (si fuera necesario implementarlo)
}
