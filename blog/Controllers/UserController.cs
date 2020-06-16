using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        UserRepo _user;
        public UserController(UserRepo user)
        {
            _user = user;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _user.GetAll();
        }
        [HttpGet("{id}")]
        public User GetID(int id)
        {
            return _user.GetByID(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _user.Delete(id);
        }
        [HttpPost]
        public int Create(User user)
        {
           return _user.CreateUser(user);

        }
    }
}
