using AutoMapper;
using Common.Dto;
using Repository.Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : IService<CategoryDto>
    {
        private readonly IService<Category> repository;
        private readonly IMapper mapper;
        public CategoryService(IService<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public CategoryDto Add(CategoryDto category)
        {
            return mapper.Map<Category, CategoryDto>(repository.Add(mapper.Map <CategoryDto, Category>(category)));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetAll()
        {
            return mapper.Map<List<Category>,List<CategoryDto>>(repository.GetAll());
        }

        public CategoryDto GetById(int id)
        {
            return mapper.Map<Category,CategoryDto>(repository.GetById(id));
        }

        public void Update(int id, CategoryDto item)
        {
            repository.Update(id,mapper.Map<CategoryDto, Category>(item));
        }
    }
}
