using AutoMapper;
using TrinusApi.Data.Dtos.Cotista;
using TrinusApi.Models;

namespace TrinusApi.Profiles
{
    public class CotistaProfile : Profile
    {
        public CotistaProfile()
        {
            CreateMap<CriarCotistaDto, Cotista>();
            CreateMap<Cotista,LerCotistaDto>();
            CreateMap<AtualizarCotistaDto,Cotista>();
        }
    }
}
