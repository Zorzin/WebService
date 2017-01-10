using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class EventsController:Controller
    {
        public IEventRepository EventRepository { get; set; }

        public EventsController(IEventRepository eventsRepository)
        {
               EventRepository = eventsRepository;
        }

        [HttpGet]
        public IEnumerable<Event> GetAll()
        {
            return EventRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetEvents")]
        public IActionResult GetById(int id)
        {
            var item = EventRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}