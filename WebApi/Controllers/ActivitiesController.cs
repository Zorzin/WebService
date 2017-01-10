using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ActivitiesController:Controller
    {
        public IActivityRepository ActivityRepository { get; set; }

        public ActivitiesController(IActivityRepository activityRepository)
        {
            ActivityRepository = activityRepository;
        }

        [HttpGet]
        public IEnumerable<Activity> GetAll()
        {
            return ActivityRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetActivities")]
        public IActionResult GetById(int id)
        {
            var item = ActivityRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}