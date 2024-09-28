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

    public DbSet<Billboard>? Billboards { get; set;}
    public DbSet<Comment>? Comments { get; set;}
    public DbSet<Filee>? Filees  { get; set;}
    public DbSet<FileType>? FileTypes { get; set;}
    public DbSet<Person>? Persons { get; set;}
    public DbSet<User>? Users { get; set;}
    public DbSet<UserBan>? UserBans { get; set;}
    public DbSet<Post>? Posts { get; set;}
    public DbSet<Reaction>? Reactions{ get; set;}
    public DbSet<Report>? Reports {get; set;}
    public DbSet<ReportUser>? ReportUsers { get; set;}

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

