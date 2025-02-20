using Microsoft.EntityFrameworkCore;
using Melodex.Infrastructure.Data;
using Melodex.Application.Interfaces;
using Melodex.Application.Services;
using Melodex.Infrastructure.Interfaces;
using Melodex.Infrastructure.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();

// Add application services
builder.Services.AddScoped<IVinylService, VinylService>();
builder.Services.AddScoped<IVinylRepository, VinylRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();


// Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});


// Configure PostgreSQL with Entity Framework Core
builder.Services.AddDbContext<MelodexDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add AutoMapper for DTOs
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication(); // Asegúrate de que esté antes de UseAuthorization

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
