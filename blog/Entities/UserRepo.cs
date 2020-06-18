using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public class UserRepo:IUserRepo
    {
        Context db;
        public UserRepo(Context context)
        {
            db = context;
        }
        public int CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
        }
        public User GetByID(int id)
        {
            return db.Users.FirstOrDefault(x => x.ID == id);
        }
        public void Update(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
