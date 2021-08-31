using System.Drawing;
using AutoMapper;
using Pet.Application.Dtos;

namespace Pet.Application.Mappers.Person
{
    public class ModelToDtoPersonMapping : Profile
    {
        public ModelToDtoPersonMapping()
        {
            PersonMap();
        }

        private void PersonMap()
        {
            CreateMap<Domain.Models.Person, PersonDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(c => c.BirthDate))
                .ForMember(dest => dest.Documents, opt => opt.MapFrom(c => c.Documents));
        }
    }
}