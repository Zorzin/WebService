using System.Collections.Generic;
using WebApi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Repository
{
    public class EventRepository : IEventRepository
    {
        private MyDbContext _db;


        public EventRepository(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(Event @event)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Event> GetAll()
        {
            return _db.Events
                .ToList();
        }

        public Event Find(int key)
        {
            return _db.Events
                .FirstOrDefault(a => a.EventID == key);
        }

        public bool CheckValidUserKey(string reqkey)
        {
            throw new System.NotImplementedException();
        }
    }
}