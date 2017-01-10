using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PlacesController:Controller
    {
        public IPlaceRepository PlaceRepository { get; set; }

        public PlacesController(IPlaceRepository placeRepository)
        {
            PlaceRepository = placeRepository;
        }

        [HttpGet]
        public IEnumerable<Place> GetAll()
        {
            return PlaceRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetPlaces")]
        public IActionResult GetById(int id)
        {
            var item = PlaceRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}