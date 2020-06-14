using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public class Post
    {
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorID { get; set; }
        
    }
}
