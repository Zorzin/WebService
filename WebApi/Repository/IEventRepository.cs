using System.Collections.Generic;

namespace WebApi.Repository
{
    public interface IEventRepository
    {
        void Add(Event activity);
        IEnumerable<Event> GetAll();
        Event Find(int key);

        bool CheckValidUserKey(string reqkey);
    }
}