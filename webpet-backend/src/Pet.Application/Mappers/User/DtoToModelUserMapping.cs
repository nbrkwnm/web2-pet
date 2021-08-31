using AutoMapper;
using Pet.Application.Dtos;

namespace Pet.Application.Mappers.User
{
    public class DtoToModelUserMapping : Profile
    {
        public DtoToModelUserMapping()
        {
            UserMap();
        }

        private void UserMap()
        {
            CreateMap<UserDto, Domain.Models.User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Username, opt => opt.MapFrom(c => c.Username))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(c => c.Password))
                .ForMember(dest => dest.Person, opt => opt.MapFrom(c => c.Person));
        }
    }
}