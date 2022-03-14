using AutoMapper;
using TodoApi.ViewModels;

namespace TodoApi.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName.Substring(0, src.UserName.Length - 3)));
            CreateMap<UserViewModel, User>();
        }
    }
}