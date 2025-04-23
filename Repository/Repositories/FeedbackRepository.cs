using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class FeedbackRepository: IRepository<Feedback>
    {
        private readonly IContext context;
        public FeedbackRepository(IContext context)
        {
            this.context = context;
        }
        public Feedback Add(Feedback item)
        {
            context.Feedbacks.Add(item);
            context.Save();
            return item;
        }

        public void Delete(int id)
        {
            context.Feedbacks.Remove(GetById(id));
            context.Save();
        }

        public List<Feedback> GetAll()
        {
            return context.Feedbacks.ToList();
        }

        public Feedback GetById(int id)
        {
            return context.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Feedback item)
        {
            var existFeedback = GetById(id);
            if (existFeedback != null)
            {
                existFeedback.User = item.User;
                existFeedback.Type = item.Type;
                context.Save();
            }
        }
    }
}
