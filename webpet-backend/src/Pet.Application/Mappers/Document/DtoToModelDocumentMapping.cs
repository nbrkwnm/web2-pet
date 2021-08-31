using AutoMapper;
using Pet.Application.Dtos;

namespace Pet.Application.Mappers.Document
{
    public class DtoToModelDocumentMapping : Profile
    {
        public DtoToModelDocumentMapping()
        {
            DocumentMap();
        }

        private void DocumentMap()
        {
            CreateMap<DocumentDto, Domain.Models.Document>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(c => c.Type))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(c => c.Number));
        }
    }
}