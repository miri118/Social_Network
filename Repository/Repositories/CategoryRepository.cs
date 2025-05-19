using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext context;

        public CategoryRepository()
        {
            
        }
        public Task<Category> Add(Category item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Category item)
        {
            throw new NotImplementedException();
        }
        //public CategoryRepository(IContext context)
        //{
        //    this.context = context;
        //}
        //public Category Add(Category item)
        //{
        //    this.context.Categories.Add(item);
        //    this.context.Save();
        //    return item;
        //}

        //public void Delete(int id)
        //{
        //    this.context.Categories.Remove(GetById(id));
        //    this.context.Save();
        //}

        //public List<Category> GetAll()
        //{
        //    return context.Categories.ToList();
        //}

        //public Category GetById(int id)
        //{
        //    return context.Categories.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, Category item)
        //{
        //    var existCategory = GetById(id);
        //    if (existCategory != null)
        //    {
        //        existCategory.NameCategory = item.NameCategory;
        //        existCategory.Topics = item.Topics;
        //        context.Save();
        //    }
        //}
    }
}
