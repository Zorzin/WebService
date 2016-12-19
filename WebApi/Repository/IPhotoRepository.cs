using System.Collections.Generic;

namespace WebApi.Repository
{
    public interface IPhotoRepository
    {
        void Add(Photo photo);
        IEnumerable<Photo> GetAll();
        Photo Find(int key);

        bool CheckValidUserKey(string reqkey);
    }
}