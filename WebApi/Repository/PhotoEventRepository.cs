using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repository
{
    public class PhotoEventRepository : IPhotoEventRepository
    {
        private MyDbContext _db;


        public PhotoEventRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(PhotoEvent photo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PhotoEvent> GetAll()
        {
            return _db.PhotoEvents.AsNoTracking().ToList();
        }

        public PhotoEvent Find(int key)
        {
            return _db.PhotoEvents.AsNoTracking().FirstOrDefault(p => p.PhotoEventID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}
