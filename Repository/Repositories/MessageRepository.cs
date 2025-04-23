using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MessageRepository:IRepository<Message>
    {
        private readonly IContext context;
        public MessageRepository(IContext context)
        {
            this.context = context;
        }
        public Message Add(Message item)
        {
            context.Messages.Add(item);
            context.Save();
            return item;
        }

        public void Delete(int id)
        {
            context.Messages.Remove(GetById(id));
            context.Save();
        }

        public List<Message> GetAll()
        {
            return context.Messages.ToList();
        }

        public Message GetById(int id)
        {
            return context.Messages.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Message item)
        {
            var existMessage = GetById(id);
            if (existMessage != null)
            {
                existMessage.Content = item.Content;
                existMessage.User = item.User;
                existMessage.Likes = item.Likes;
                //existMessage.TimeSend = item.TimeSend; // אולי לא נכון לשנות זמן שליחה!?
                context.Save();
            }
        }
    }
}
