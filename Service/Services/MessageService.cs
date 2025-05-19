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
    public class MessageService : IService<MessageDto>
    {
        private readonly IRepository<Message> repository;
        private readonly IMapper mapper;
        public MessageService(IRepository<Message> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public MessageDto Add(MessageDto user)
        {
            return mapper.Map<Message, MessageDto>(repository.Add(mapper.Map<MessageDto, Message>(user)));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<MessageDto> GetAll()
        {
            return mapper.Map<List<Message>, List<MessageDto>>(repository.GetAll());
        }

        public MessageDto GetById(int id)
        {
            return mapper.Map<Message, MessageDto>(repository.GetById(id));
        }

        public void Update(int id, MessageDto item)
        {
            repository.Update(id, mapper.Map<MessageDto, Message>(item));
        }
    }
}
