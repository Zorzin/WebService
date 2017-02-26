using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repository
{
    public class PlaceRepository :IPlaceRepository
    {
        private MyDbContext _db;


        public PlaceRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(Place place)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Place> GetAll()
        {
            return _db.Places.ToList();
        }

        public Place Find(int key)
        {
            return _db.Places.FirstOrDefault(p => p.PlaceID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}