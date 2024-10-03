using dao_library.Interfaces.reaction;
using entities_library.reactions;


namespace dao_library.entity_framework.reaction;


public class DAOEFReaction : IDAOReaction
{
private readonly ApplicationDbContext context;


public DAOEFReaction(ApplicationDbContext context)
{
this.context = context;}


public Task<IEnumerable<Reaction>> GetAll()
{
    throw new NotImplementedException();
}
public Task<Reaction> GetById(long id){
throw new NotImplementedException();}


public Task Save(Reaction reaction)
{
    throw new NotImplementedException();
}

public Task Delete(Reaction reaction)
{
    throw new NotImplementedException();
}
}
