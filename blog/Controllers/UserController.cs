using System.Collections.Generic;
using blog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepo _user;
        public UserController(IUserRepo user)
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
        [HttpPut]
        public void Update([FromBody]Upd upd)
        {
            var user = _user.GetByID(upd.Id);
            user.Login = upd.Login;
            user.Password = upd.Password;
            _user.Update(user);
        }
       
    }
}
