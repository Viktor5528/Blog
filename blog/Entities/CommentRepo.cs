using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public class CommentRepo
    {
        Context db;
        public CommentRepo(Context context)
        {
            db = context;
        }
        public int Create(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return comment.ID;
        }
        public List<Comment> GetAll()
        {
            return db.Comments.ToList();
        }
        public Comment GetByID(int id)
        {
            return db.Comments.FirstOrDefault(x => x.ID == id);
        }
        public void Update(Comment comment)
        {
            db.Comments.Update(comment);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var comment = db.Comments.Find(id);
            if (comment != null)
            {
                db.Comments.Remove(comment);
                db.SaveChanges();
            }
        }

    }
}
