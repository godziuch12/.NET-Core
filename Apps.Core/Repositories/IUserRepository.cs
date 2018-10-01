using System;
using System.Collections.Generic;
using Apps.Core.Domain;

namespace Apps.Core.Repositories
{
    public interface IUserRepository
    {      
        User GetUser(Guid id);
        User GetUser(string email);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Remove(Guid id);
    }
}