using dao_library.Interfaces.login;
using entities_library.login;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace dao_library.entity_framework.login;

public class DAOEFUser : IDAOUser
{
    private readonly ApplicationDbContext context;

    public DAOEFUser(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> Get(string userName, string password)
    {
        if(userName == null) return null;
        if(context.User == null) return null;

        User? user = await context.User
            .Where(user => user.Mail.ToLower() == userName.ToLower())
            .FirstOrDefaultAsync();

        return user;
    }

    public async Task<(IEnumerable<User>, int)> GetAll(
        string? query,
        int page,
        int pageSize
    )
    {
        IQueryable<User> userQuery = context.User;

        if(query != null)
        {
            userQuery = userQuery.Where(
                p => p.Mail.Contains(query) || p.Name.Contains(query));
        }

        int totalRecords = await userQuery.CountAsync();

        var users = await userQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (users, totalRecords);
    }

    public Task Save(User user)
    {
        throw new NotImplementedException();
    }
}