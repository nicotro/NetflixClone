using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using NetflixCloneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContextService>();
builder.Services.AddScoped<BaseRepository<Faq>, FaqRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
