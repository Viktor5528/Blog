using System;
using System.Collections.Generic;
using blog.Entities;
using blog.Entities.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        IPostRepo _post;
        public PostController(IPostRepo post)
        {
            _post = post; ;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public List<Post> Get()
        {
            return _post.GetAll();
        }
        [HttpGet("{id}")]
        public Post GetID(int id)
        {
            return _post.GetByID(id);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _post.Delete(id);
        }
        [HttpPost]
        public int Create(Post post)
        {
            if(post.Description ==null ||  post.Title == null)
            {
                throw new Exception("All fields must be filled in");
            }
            return _post.Create(post);

        }
        [HttpPut]
        public void Update(Post post)
        {
            _post.Update(post);
        }
        
    }
}
