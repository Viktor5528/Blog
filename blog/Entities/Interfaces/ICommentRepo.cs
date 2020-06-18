using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities.Interfaces
{
    public interface ICommentRepo
    {
        int Create(Comment comment);
        List<Comment> GetAll();
        Comment GetByID(int id);
        void Update(Comment comment);
        void Delete(int id);
    }
}
