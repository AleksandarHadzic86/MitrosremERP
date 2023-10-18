using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Aplication.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {           
            CreateMap<Zaposleni, ZaposleniVM>().ReverseMap();
            CreateMap<Zaposleni, ZaposleniVMIndex>().ReverseMap();
            CreateMap<StepenStrucneSpreme, SelectListItem>()              
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.StepenObrazovanja))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));
            CreateMap<Ugovor, UgovoriVM>().ReverseMap();
            CreateMap<Ugovor, Zaposleni>().ReverseMap();
            //CreateMap<UgovoriVM, Zaposleni>().ReverseMap();
            CreateMap<Bolovanje, BolovanjeVM>().ReverseMap();
            CreateMap<GodisnjiOdmor, GodisnjiVM>().ReverseMap();
            CreateMap<DokumentiZaposleni, DokumentiZaposleniVM>().ReverseMap();
        }
    }
}
