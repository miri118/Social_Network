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
    public class UserService : IService<UserDto>
    {
        private readonly IRepository<User> repository;
        private readonly IMapper mapper;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<UserDto> Add(UserDto user)
        {
            return mapper.Map<UserDto>(await repository.Add(mapper.Map<User>(user)));
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<List<UserDto>> GetAll()
        {
            return mapper.Map<List<UserDto>>(await repository.GetAll());
        }

        public async Task<UserDto> GetById(int id)
        {
            return mapper.Map<UserDto>(await repository.GetById(id));
        }

        public async Task Update(int id, UserDto item)
        {
            await repository.Update(id, mapper.Map<User>(item));
        }
    }
}
