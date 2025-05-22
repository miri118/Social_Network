using AutoMapper;
using Common.Dto;
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TopicService : IService<TopicDto>
    {
        private readonly IRepository<Topic> repository;
        private readonly IMapper mapper;
        public TopicService(IRepository<Topic> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public TopicDto Add(TopicDto user)
        {
            return mapper.Map<TopicDto>(repository.Add(mapper.Map<Topic>(user)));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<TopicDto> GetAll()
        {
            return mapper.Map<List<TopicDto>>(repository.GetAll());
        }

        public TopicDto GetById(int id)
        {
            return mapper.Map<TopicDto>(repository.GetById(id));
        }

        public void Update(int id, TopicDto item)
        {
            repository.Update(id, mapper.Map<Topic>(item));
        }
    }
}
