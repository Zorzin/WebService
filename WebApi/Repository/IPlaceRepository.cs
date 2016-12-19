using System.Collections.Generic;

namespace WebApi.Repository
{
    public interface IPlaceRepository
    {
        void Add(Place place);
        IEnumerable<Place> GetAll();
        Place Find(int key);

        bool CheckValidUserKey(string reqkey);
    }
}