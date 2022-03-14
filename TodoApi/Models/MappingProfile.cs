using AutoMapper;
using TodoApi.ViewModels;

namespace TodoApi.Models{
    public class MappingProfile : Profile{
        public MappingProfile(){
            CreateMap<User,UserViewModel>();
            CreateMap<UserViewModel,User>();
        }
    }
}