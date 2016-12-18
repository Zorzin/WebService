using System.Collections.Generic;

namespace WebApi.Repository
{
    public interface IActivityRepository
    {
        void Add(Activity activity);
        IEnumerable<Activity> GetAll();
        Activity Find(int key);

        bool CheckValidUserKey(string reqkey);
    }
}