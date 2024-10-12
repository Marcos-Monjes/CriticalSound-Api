using entities_library.genre;

namespace dao_library.Interfaces.genre;


public interface IDAOGenre
{
    Task<IEnumerable<Genre>> GetAll();  
    Task<Genre?> GetById(long? id);
    Task<Genre?> GetByType(string genreType);        

    Task Save(Genre genre);           
    Task Delete(Genre genre);        
}
