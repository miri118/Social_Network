using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class TopicRepository : IRepository<Topic>
    {
        private readonly IContext context;
        public TopicRepository(IContext context)
        {
            this.context = context;
        }
        public Topic Add(Topic item)
        {
            context.Topics.Add(item);
            context.Save();
            return item;
        }

        public void Delete(int id)
        {
            context.Topics.Remove(GetById(id));
            context.Save();
        }

        public List<Topic> GetAll()
        {
           return context.Topics.ToList();
        }

        public Topic GetById(int id)
        {
            return context.Topics.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Topic item)
        {
            var existTopic = GetById(id);
            if(existTopic != null)
            {
                existTopic.Title = item.Title;
                existTopic.ListMessages = item.ListMessages;
                existTopic.Category = item.Category;
                context.Save();
            }
        }
    }
}
