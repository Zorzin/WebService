using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repository
{
    public class PhotoRepository :IPhotoRepository
    {
        private MyDbContext _db;


        public PhotoRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(Photo photo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Photo> GetAll()
        {
            return _db.Photos.AsNoTracking().ToList();
        }

        public Photo Find(int key)
        {
            return _db.Photos.AsNoTracking().FirstOrDefault(p => p.PhotoID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}