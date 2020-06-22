using System;
using blog.Entities;
using blog.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        ICommentRepo _comment;
        public CommentController(ICommentRepo comment)
        {
            _comment = comment;
        }

        [HttpGet]
        public IActionResult Get()
        {
          return Ok(_comment.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetID(int id)
        {
          return Ok(_comment.GetByID(id));
           
        }
        [HttpGet("message")]
        public string GetMessage(Comment comment)
        {
            return comment.Message;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _comment.Delete(id);
        }
        [HttpPost]
        public int Create(Comment comment)
        {
            if (comment.Message == null)
            {
                throw new Exception("Message is null");
            }
            return _comment.Create(comment);

        }
    }
}
