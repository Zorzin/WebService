using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PhotosController :Controller
    {
        public IPhotoRepository PhotoRepository { get; set; }

        public PhotosController(IPhotoRepository photosRepository)
        {
            PhotoRepository = photosRepository;
        }

        [HttpGet]
        public IEnumerable<Photo> GetAll()
        {
            return PhotoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetPhotos")]
        public IActionResult GetById(int id)
        {
            var item = PhotoRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}