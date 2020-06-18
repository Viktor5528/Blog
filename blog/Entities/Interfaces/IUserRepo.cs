using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Entities
{
    public interface IUserRepo
    {
        int CreateUser(User user);
        List<User> GetAll();
        User GetByID(int id);
        void Update(User user);
        void Delete(int id);
    }
}
