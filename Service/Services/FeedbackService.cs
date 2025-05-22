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
    public class FeedbackService : IService<FeedbackDto>
    {
        private readonly IRepository<Feedback> repository;
        private readonly IMapper mapper;
        public FeedbackService(IRepository<Feedback> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public FeedbackDto Add(FeedbackDto user)
        {
            return mapper.Map<FeedbackDto>(repository.Add(mapper.Map<Feedback>(user)));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<FeedbackDto> GetAll()
        {
            return mapper.Map<List<FeedbackDto>>(repository.GetAll());
        }

        public FeedbackDto GetById(int id)
        {
            return mapper.Map<FeedbackDto>(repository.GetById(id));
        }

        public void Update(int id, FeedbackDto item)
        {
            repository.Update(id, mapper.Map<Feedback>(item));
        }
    }
}
