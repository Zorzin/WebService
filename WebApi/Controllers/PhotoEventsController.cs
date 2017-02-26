using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PhotoEventsController : Controller
    {
        public IPhotoEventRepository PhotoEventRepository { get; set; }

        public PhotoEventsController(IPhotoEventRepository photoeventsRepository)
        {
            PhotoEventRepository = photoeventsRepository;
        }

        [HttpGet]
        public IEnumerable<PhotoEvent> GetAll()
        {
            return PhotoEventRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetPhotoEvents")]
        public IActionResult GetById(int id)
        {
            var item = PhotoEventRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
