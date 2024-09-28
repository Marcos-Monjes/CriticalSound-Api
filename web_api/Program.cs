using dao_library;
using dao_library.entity_framework;
using dao_library.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        "Server=localhost;Database=CriticalSound;Uid=root;Pwd=password",
        new MySqlServerVersion(
            new Version(8, 0, 21)
        )
    )
    
);

builder.Services.AddScoped<IDAOFactory, DAOEFFactory>();

builder.Services.AddCors(options => 
{
    options.AddPolicy("AllowAll",
        policy => 
        {
            policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
