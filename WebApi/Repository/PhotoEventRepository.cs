using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return _db.PhotoEvents.ToList();
        }

        public PhotoEvent Find(int key)
        {
            return _db.PhotoEvents.FirstOrDefault(p => p.PhotoID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}
