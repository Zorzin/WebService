using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    public interface IPhotoEventRepository
    {
        void Add(PhotoEvent photo);
        IEnumerable<PhotoEvent> GetAll();
        PhotoEvent Find(int key);

        bool CheckValidUserKey(string reqkey);
    }
}
