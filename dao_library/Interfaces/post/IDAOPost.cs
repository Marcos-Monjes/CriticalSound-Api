using entities_library.post;

namespace dao_library.Interfaces.post;

public interface IDAOPost
{
    Task<IEnumerable<Post>> GetAll();
    Task<Post> GetById(long id);

    //En nuestro caso necesitamos devolver lo comentado abajo por lo de billboard.
    // Task<Post> GetMostLiked(list);
    // Task<Post> GetMostCritized(list);
    Task Save(Post post);
    
    //NO PROGRAMAR
    Task Delete(Post post);
}