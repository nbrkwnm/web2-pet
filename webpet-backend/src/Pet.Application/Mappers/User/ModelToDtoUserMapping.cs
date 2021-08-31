using AutoMapper;
using Pet.Application.Dtos;

namespace Pet.Application.Mappers.User
{
    public class ModelToDtoUserMapping : Profile
    {
        public ModelToDtoUserMapping()
        {
            UserMap();
        }
        
        private void UserMap()
        {
            CreateMap<Domain.Models.User, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(c => c.Username))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(c => c.Password))
                .ForMember(dest => dest.Person, opt => opt.MapFrom(c => c.Person));
        }
    }
}