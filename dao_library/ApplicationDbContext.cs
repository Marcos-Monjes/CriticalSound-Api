using System.Data.Common;
using entities_library.ban;
using entities_library.billboard;
using entities_library.genre;
using entities_library.comment;
using entities_library.file_system;
using entities_library.login;
using entities_library.post;
using entities_library.reactions;
using Microsoft.EntityFrameworkCore;

namespace dao_library;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<Billboard>? Billboard { get; set;}
    public DbSet<Comment>? Comment { get; set;}
    public DbSet<Filee>? Filee  { get; set;}
    public DbSet<FileType>? FileType { get; set;}
    public DbSet<Person>? Person { get; set;}
    public DbSet<User>? User { get; set;}
    public DbSet<UserBan>? UserBan { get; set;}
    public DbSet<Post>? Post { get; set;}
    public DbSet<Reaction>? Reaction{ get; set;}
    public DbSet<Genre>? Genre { get; set;}


    // Sobrescribimos el método OnModelCreating para definir la relación uno a uno
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurar la relación uno a uno entre Post y Billboard
        modelBuilder.Entity<Post>()
            .HasOne(p => p.Billboard)
            .WithOne(b => b.Post)
            .HasForeignKey<Billboard>(b => b.PostId); // Definir la clave foránea en Billboard

        base.OnModelCreating(modelBuilder);
    }
}

