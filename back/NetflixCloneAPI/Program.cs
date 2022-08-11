using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using NetflixCloneAPI.Services;
using System.Text;
using static NetflixCloneAPI.Interfaces.Ilogin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContextService>();
builder.Services.AddScoped<ILogin, LoginService>();
builder.Services.AddScoped<BaseRepository<Faq>, FaqRepository>();
builder.Services.AddScoped<BaseRepository<User>, UserRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder
            .SetIsOriginAllowed(isOriginAllowed: _ => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
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
builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy("admin", options =>
    {
        options.RequireRole("admin");
    });
    builder.AddPolicy("users", options =>
    {
        options.RequireRole("admin","user");
    });
});
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
