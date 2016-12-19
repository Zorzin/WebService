using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Repository
{
    public class UserRepository :IUserRepository
    {
        private MyDbContext _db;


        public UserRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User Find(string key)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}