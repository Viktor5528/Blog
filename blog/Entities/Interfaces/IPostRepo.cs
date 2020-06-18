using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities.Interfaces
{
   public interface IPostRepo
    {
        int Create(Post post);
        List<Post> GetAll();
        Post GetByID(int id);
        void Update(Post post);
        void Delete(int id);
    }
}
