using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public User Add(User user)
        {
            var addUser = _db.Users.Add(user);
            _db.SaveChanges();
            user.Id = addUser.Entity.Id;
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users.AsNoTracking().ToList();
        }

        public User Find(string key)
        {
            return _db.Users.AsNoTracking().FirstOrDefault(u => u.Id == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}