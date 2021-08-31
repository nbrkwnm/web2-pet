using System.Net.Http;
using AutoMapper;
using Pet.Application.Dtos;

namespace Pet.Application.Mappers.Person
{
    public class DtoToModelPersonMapping : Profile
    {
        public DtoToModelPersonMapping()
        {
            UserMap();
        }

        private void UserMap()
        {
            CreateMap<PersonDto, Domain.Models.Person>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(c => c.BirthDate))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(dest => dest.Documents, opt => opt.MapFrom(c => c.Documents));
        }
    }
}