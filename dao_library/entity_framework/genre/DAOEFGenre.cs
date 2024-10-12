using dao_library.Interfaces.genre;
using entities_library.genre;
using Microsoft.EntityFrameworkCore;

namespace dao_library.entity_framework.genre;

public class DAOEFGenre : IDAOGenre 
{
    private readonly ApplicationDbContext context;

    public DAOEFGenre(ApplicationDbContext context)
    {
        this.context = context;
    }

    public Task Delete(Genre genre)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Genre>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Genre?> GetById(long? id)
    {
        if (id == null) return null;
        if (context.Genres == null) return null;

        Genre? genreId = await context.Genres
            .Where(genreId => genreId.id == id)
            .FirstOrDefaultAsync();

        return genreId;
    }

    public async Task<Genre?> GetByType(string genreType)
    {
        if (genreType == null) return null;
        if (context.Genres == null) return null;

        Genre? genre = await context.Genres
            .Where(genre => genre.genreType.ToLower() == genreType.ToLower())
            .FirstOrDefaultAsync();

        return genre;
    }

    public async Task Save(Genre genre)
    {
        if (genre == null){
            throw new ArgumentNullException(nameof(genre));
        }
        await context.Genres.AddAsync(genre);
        await context.SaveChangesAsync(); 
    }
}
