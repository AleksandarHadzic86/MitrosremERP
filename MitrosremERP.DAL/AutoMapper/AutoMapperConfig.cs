using AutoMapper;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Aplication.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Zaposleni, ZaposleniVM>().ReverseMap();
        }
    }
}
