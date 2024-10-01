using entities_library.billboard;

namespace dao_library.Interfaces.billboard;

public interface IDAOBillboard
{
    Task<IEnumerable<Billboard>> GetAll();
    Task<Billboard> GetById(long id);
    Task Save(Billboard billboard);
    
    //NO PROGRAMAR
    Task Delete(Billboard billboard);
}