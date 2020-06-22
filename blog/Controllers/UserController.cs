using System;
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
        public int Create([FromBody]User user)
        {
            if (!user.Login.EndsWith(".com"))
            {
                throw new Exception("use a normal email address");
            }
            if (user.Age < 16)
            {
                throw new Exception("get some experience, youngster");
            }
            if (user.Name.Length > 20)
            {
                throw new Exception("I've never seen such long names before");
            }
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
