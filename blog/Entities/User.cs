using System.Collections.Generic;

namespace blog.Entities
{
    public class User
    {
        public List<Post> Posts { get; set; } = new List<Post>();
        public bool IsAuthor { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

    }
}
