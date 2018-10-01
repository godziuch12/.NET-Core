using Apps.Infrastructure.DTO;

namespace Apps.Infrastructure.Services
{
    public interface IUserService
    {
         UserDTO GetDTO(string email);
         void Register(string email, string username, string password);
    }
}