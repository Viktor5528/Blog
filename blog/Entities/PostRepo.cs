using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public class PostRepo
    {
        Context db;
        public PostRepo(Context context)
        {
            db = context;
        }
        public int Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return post.ID;
        }
        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }
        public Post GetByID(int id)
        {
            return db.Posts.Include(x=>x.Comments).FirstOrDefault(x => x.ID == id);
        }
        public void Update(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var post = db.Posts.Find(id);
            if (post != null)
            {
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }
       
    }
}
