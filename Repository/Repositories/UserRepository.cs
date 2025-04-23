using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IContext context;
        public UserRepository(IContext context)
        {
            this.context = context;
        }
        public User Add(User item)
        {
            context.Users.Add(item);
            context.Save();
            return item;
        }

        public void Delete(int id)
        {
            context.Users.Remove(GetById(id));
            context.Save();
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, User item)
        {
            var existUser = GetById(id);   
            if(existUser != null)
            {
                existUser.Name = item.Name;
                existUser.Password = item.Password;
                existUser.Role = item.Role;
                //existUser.CountMessages = item.CountMessages; // האם נכון!?
                context.Save();
            }
        }
    }
}
