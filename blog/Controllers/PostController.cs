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
    public class PostController : ControllerBase
    {
        PostRepo _post;
        public PostController(PostRepo post)
        {
            _post = post; ;
        }

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
            return _post.Create(post);

        }
        [HttpPut]
        public void Update(Post post)
        {
            _post.Update(post);
        }
    }
}
