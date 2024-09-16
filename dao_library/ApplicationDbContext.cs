using System.Data.Common;
using entities_library.ban;
using entities_library.billboard;
using entities_library.comment;
using entities_library.file_system;
using entities_library.login;
using entities_library.post;
using entities_library.reactions;
using entities_library.report;
using Microsoft.EntityFrameworkCore;

namespace dao_library;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<Billboard>? Billboards { get;}
    public DbSet<Comment>? Comments { get;}
    public DbSet<Filee>? Filees  { get;}
    public DbSet<FileType>? FileTypes { get;}
    public DbSet<Person>? Persons { get;}
    public DbSet<User>? Users { get;}
    public DbSet<UserBan>? UserBans { get;}
    public DbSet<Post>? Posts { get;}
    public DbSet<Reaction>? Reactions{ get;}
    public DbSet<Report>? Reports {get;}
    public DbSet<ReportUser>? ReportUsers { get;}

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

