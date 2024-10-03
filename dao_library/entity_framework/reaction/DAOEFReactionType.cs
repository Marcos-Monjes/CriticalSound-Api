using dao_library.entity_framework.reaction;
using dao_library.Interfaces.reaction;
using entities_library.reactions;


namespace dao_library.entity_framework.reaction;


public class DAOEFReactionType : IDAOReactionType
{
    private readonly ApplicationDbContext context; 
    public DAOEFReactionType(ApplicationDbContext context)
{
    this.context = context;
}
public Task<IEnumerable<Reaction>> GetAll()
{
    throw new NotImplementedException();
}

public Task<Reaction> GetById(long id)
{
    throw new NotImplementedException();
}


public Task Save(ReactionType reactionType)
{
    throw new NotImplementedException();
}

public Task Delete(ReactionType reactionType)
{
    throw new NotImplementedException();
}


public Task Delete(Reaction reactionType)
{
    throw new NotImplementedException();
}
}
