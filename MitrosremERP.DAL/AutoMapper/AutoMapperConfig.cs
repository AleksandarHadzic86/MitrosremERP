using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Aplication.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Zaposleni, ZaposleniVM>().ReverseMap();
            CreateMap<StepenStrucneSpreme, SelectListItem>()              
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.StepenObrazovanja))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));
            CreateMap<Pol, SelectListItem>()
                 .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.PolOsobe))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));


        }
    }
}
