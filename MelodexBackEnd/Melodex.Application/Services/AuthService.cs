using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Melodex.Domain.Models;
using Melodex.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Melodex.Application.Interfaces;

namespace Melodex.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly MelodexDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(MelodexDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<string> Authenticate(AuthRequest request)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return null; // Mejor retornar un mensaje de error para más claridad en el cliente.
            }

            return GenerateJwtToken(user);
        }

        public async Task<bool> Register(User user)
        {
            // Verificamos si el email ya está registrado.
            if (await _context.Users.AnyAsync(u => u.Email == user.Email))
                return false;

            // Creamos el hash de la contraseña.
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            // Añadimos el usuario a la base de datos primero
            _context.Users.Add(user);

            // Creamos la colección para el nuevo usuario
            var collection = new Collection
            {
                UserId = user.Id, // El UserId se asignará correctamente después de que el usuario sea creado
                User = user // Establecemos la relación bidireccional
            };

            // Asignamos la colección al usuario
            user.Collection = collection;

            // Añadimos la colección a la base de datos
            _context.Collections.Add(collection);

            // Guardamos los cambios en la base de datos
            await _context.SaveChangesAsync();
            return true;
        }




        private string GenerateJwtToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(3), // Ajusta el tiempo de expiración según lo que necesites
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
