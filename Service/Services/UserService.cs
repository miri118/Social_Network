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
        public UserDto Add(UserDto user)
        {
            return mapper.Map<User, UserDto>(repository.Add(mapper.Map<UserDto, User>(user)));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<UserDto> GetAll()
        {
            return mapper.Map<List<User>, List<UserDto>>(repository.GetAll());
        }

        public UserDto GetById(int id)
        {
            return mapper.Map<User, UserDto>(repository.GetById(id));
        }

        public void Update(int id, UserDto item)
        {
            repository.Update(id, mapper.Map<UserDto, User>(item));
        }
    }
}
