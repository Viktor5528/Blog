using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public int PostID { get; set; }

    }
}
