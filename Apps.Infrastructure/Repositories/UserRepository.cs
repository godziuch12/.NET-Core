using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Core.Domain;
using Apps.Core.Repositories;

namespace Apps.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>{
            new User("user1@wp.pl","user1","password","salt"),
            new User("user2@wp.pl","user2","password","salt"),
            new User("user3@wp.pl","user3","password","salt")
        };
        public void Add(User user)
        {
            _users.Add(user);
        }
        public User GetUser(Guid id) => _users.Single(x => x.Id == id);

        public User GetUser(string email) => _users.Single(x => x.Email == email.ToLowerInvariant());

        public IEnumerable<User> GetAll() => _users;

        public void Remove(Guid id)
        {
            var user = GetUser(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
        }
    }
}