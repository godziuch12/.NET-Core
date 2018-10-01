using System;
using Apps.Core.Domain;
using Apps.Core.Repositories;
using Apps.Infrastructure.DTO;

namespace Apps.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO GetDTO(string email)
        {
            var user = _userRepository.GetUser(email);

            return new UserDTO
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                FulName = user.FulName
            };
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.GetUser(email);
            if (user != null)
            {
                throw new Exception("User instnieje");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
        }
    }
}