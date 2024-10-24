using System.Data.Common;
using entities_library.genre;
using entities_library.comment;
using entities_library.file_system;
using entities_library.login;
using entities_library.reactions;
using Microsoft.EntityFrameworkCore;
using entities_library.song;

namespace dao_library;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<Comment>? Comments { get; set;}
    public DbSet<entities_library.file_system.File>? Files  { get; set;}
    public DbSet<FileType>? FileTypes { get; set;}
    public DbSet<Person>? Persons { get; set;}
    public DbSet<User>? Users { get; set;}
    public DbSet<UserBan>? UserBans { get; set;}
    public DbSet<Song>? Songs { get; set;}
    public DbSet<Reaction>? Reactions { get; set;}
    public DbSet<Genre>? Genres { get; set;}


    // Sobrescribimos el método OnModelCreating para definir la relación uno a uno
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

