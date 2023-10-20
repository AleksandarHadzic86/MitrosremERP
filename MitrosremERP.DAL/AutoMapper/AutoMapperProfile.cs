using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Aplication.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {           
            CreateMap<Zaposleni, ZaposleniVM>().ReverseMap();
            CreateMap<Zaposleni, ZaposleniVMIndex>().ReverseMap();
            CreateMap<StepenStrucneSpreme, SelectListItem>()              
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.StepenObrazovanja))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));
            CreateMap<Ugovor, UgovoriVM>().ReverseMap();
            CreateMap<Ugovor, UgovoriVMIndex>().ReverseMap();
            CreateMap<Ugovor, Zaposleni>().ReverseMap();
            CreateMap<Ugovor, UgovorUpdateVM>().ReverseMap();
            CreateMap<UgovoriVM, Zaposleni>().ReverseMap();
            CreateMap<Bolovanje, BolovanjeVM>().ReverseMap();
            CreateMap<GodisnjiOdmor, GodisnjiVM>().ReverseMap();
            CreateMap<DokumentiZaposleni, DokumentiZaposleniVM>().ReverseMap();

            //CreateMap<Ugovor, KreirajUgovorVM>().ReverseMap();
            CreateMap<Ugovor, KreirajUgovorVM>()
                .ForMember(dest => dest.UgovorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UgovorBrojUgovora, opt => opt.MapFrom(src => src.BrojUgovora))
                .ForMember(dest => dest.UgovorDatumPocetka, opt => opt.MapFrom(src => src.DatumPocetka))
                .ForMember(dest => dest.UgovorDatumZavrsetka, opt => opt.MapFrom(src => src.DatumZavrsetka))
                .ForMember(dest => dest.UgovorBrojDanaGodisnjeg, opt => opt.MapFrom(src => src.BrojDanaGodisnjeg))
                .ForMember(dest => dest.UgovorNapomena, opt => opt.MapFrom(src => src.Napomena))
                .ForMember(dest => dest.ZaposleniId, opt => opt.MapFrom(src => src.ZaposleniId));

            // Add more properties as needed

            // Reverse map (if needed)
            CreateMap<KreirajUgovorVM, Ugovor>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UgovorId))
                .ForMember(dest => dest.BrojUgovora, opt => opt.MapFrom(src => src.UgovorBrojUgovora))
                .ForMember(dest => dest.DatumPocetka, opt => opt.MapFrom(src => src.UgovorDatumPocetka))
                .ForMember(dest => dest.DatumZavrsetka, opt => opt.MapFrom(src => src.UgovorDatumZavrsetka))
                .ForMember(dest => dest.BrojDanaGodisnjeg, opt => opt.MapFrom(src => src.UgovorBrojDanaGodisnjeg))
                .ForMember(dest => dest.Napomena, opt => opt.MapFrom(src => src.UgovorNapomena))
                .ForMember(dest => dest.ZaposleniId, opt => opt.MapFrom(src => src.ZaposleniId));

            // Add more properties as needed
        }
    }
    
}
