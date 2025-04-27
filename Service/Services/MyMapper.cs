using AutoMapper;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MyMapper:Profile
    {
        public MyMapper() 
        {
            CreateMap<User, UserDto>().ForMember("ArrImageProfile", x => x.MapFrom(y => File.ReadAllBytes(y.ImageProfileUrl)));
            //CreateMap<UserDto, User>().ForMember("ImageProfileUrl", x => x.MapFrom(y => File.ReadAllBytes(y.ArrImageProfile)));
        }
    }
}
