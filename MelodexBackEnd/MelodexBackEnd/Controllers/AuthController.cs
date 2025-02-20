using Microsoft.AspNetCore.Mvc;
using Melodex.Application.Services;
using Melodex.Domain.Models;
using System.Threading.Tasks;
using Melodex.Application.Interfaces;

namespace Melodex.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            var token = await _authService.Authenticate(request);
            if (token == null)
                return Unauthorized(new { message = "Credenciales incorrectas" });

            return Ok(new { token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var success = await _authService.Register(user);
            if (!success)
                return BadRequest(new { message = "El usuario ya existe" });

            return Ok(new { message = "Usuario registrado exitosamente" });
        }
    }
}
