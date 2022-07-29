using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using NetflixCloneAPI.Services;
using System.Text;
using static NetflixCloneAPI.Interfaces.Ilogin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContextService>();
builder.Services.AddScoped<ILogin, LoginService>();
builder.Services.AddScoped<BaseRepository<Faq>, FaqRepository>();
builder.Services.AddScoped<BaseRepository<User>, UserRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "NetflixClone",
        ValidAudience = "NetflixClone",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is the NetflixClone JWT token encoding string"))
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
// Cors first !
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
