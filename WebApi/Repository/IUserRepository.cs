using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        IEnumerable<User> GetAll();
        User Find(string key);

        bool CheckValidUserKey(string reqkey);
    }
}