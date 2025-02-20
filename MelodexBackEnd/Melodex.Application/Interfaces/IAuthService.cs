using Melodex.Domain.Models;

namespace Melodex.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string> Authenticate(AuthRequest request);
        Task<bool> Register(User user);
    }
}
