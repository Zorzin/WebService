using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController:Controller
    {
        public IUserRepository UserRepository { get; set; }

        public UsersController(IUserRepository usersRepository)
        {
            UserRepository = usersRepository;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetUsers")]
        public IActionResult GetById(string id)
        {
            var item = UserRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}