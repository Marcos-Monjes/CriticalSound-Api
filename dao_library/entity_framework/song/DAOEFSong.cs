using dao_library.Interfaces.song;
using entities_library.song;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace dao_library.entity_framework.song;

public class DAOEFSong : IDAOSong 
{
    private readonly ApplicationDbContext context;

    public DAOEFSong(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<(IEnumerable<Song>, int)> GetAll(
        string? query,
        int page,
        int pageSize
    )
    
    {
        if (context.Songs == null) 
        {
            throw new InvalidOperationException("Songs DbSet is not initialized.");
        }

        IQueryable<Song> querySongs = context.Songs;

        if (!string.IsNullOrWhiteSpace(query))
        {
            querySongs = querySongs.Where(
                song => song.Title.Contains(query) || song.Genre.Contains(query));
        }
        int totalRecords = await  querySongs.CountAsync();

        var songs = await querySongs
        
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (songs, totalRecords);
    }
    
    public async Task<Song?> GetById(long? id)
    {
        if (id == null) return null;
        if (context.Songs == null) return null;
        
        Song? songId = await context.Songs
            .Where(songId => songId.Id == id)
            .FirstOrDefaultAsync();
        return songId;
    }

        public async Task<Song?> GetByTitle(string title)
    {   
        if (title == null) return null;
        if (context.Songs == null) return null;

        Song? songTitle = await context.Songs
            .Where(songTitle => songTitle.Title.ToLower() == title.ToLower())
            .FirstOrDefaultAsync();
        return songTitle;
    }
        public async Task<Song?> Get(string title, string genre)
    {   
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre))
            return null;

        if (context.Songs == null)
            throw new InvalidOperationException("Songs DbSet is not initialized.");

        Song? song = await context.Songs
            .Where(song => song.Title.ToLower() == title.ToLower() && song.Genre.ToLower() == genre.ToLower())
            .FirstOrDefaultAsync();
        // if (title == null) return null;
        // if (context.Songs == null) return null;

        // Song? song = await context.Songs
        //     .Where(song => song.Title.ToLower() == title.ToLower())
        //     .FirstOrDefaultAsync();
        return song;
    }
    
    public async Task Save(Song song)
    {   
        if (song == null) throw new ArgumentNullException(nameof(song));
        if (context.Songs == null) throw new InvalidOperationException("Songs DbSet is not initialized.");

        await context.Songs.AddAsync(song);
        await context.SaveChangesAsync();
    }
        public Task Delete(Song song)
    {
        throw new NotImplementedException();
    }
}