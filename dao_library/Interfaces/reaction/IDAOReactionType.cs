using entities_library.reactions;

namespace dao_library.Interfaces.reaction;

public interface IDAOReactionType
{
//Task<IEnumerable<ReactionType>> GetAll();  //consultar utilidad
//Task<ReactionType> GetById(long id);       
Task Save(ReactionType reactionType);          
Task Delete(Reaction reactionType);       
}