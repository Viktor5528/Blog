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
    public class CommentController : ControllerBase
    {
        CommentRepo _comment;
        public CommentController(CommentRepo comment)
        {
            _comment = comment; ;
        }

        [HttpGet]
        public List<Comment> Get()
        {
            return _comment.GetAll();
        }
        [HttpGet("User")]
        public Comment GetID(int id)
        {
            return _comment.GetByID(id);
        }
        [HttpGet("message")]
        public string GetMessage(Comment comment)
        {
            return comment.Message;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _comment.Delete(id);
        }
        [HttpPost]
        public int Create(Comment comment)
        {
            return _comment.Create(comment);

        }
    }
}
