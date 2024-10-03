using entities_library.reactions;


namespace dao_library.Interfaces.reaction;




public interface IDAOReaction
{
Task<IEnumerable<Reaction>> GetAll(); 
Task<Reaction> GetById(long id);       
Task Save(Reaction reaction);          
Task Delete(Reaction reaction);       
}