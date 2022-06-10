using AutoMapper;
using TrinusApi.Data.Dtos.Operacao;
using TrinusApi.Data.Dtos.OperacaoDto;
using TrinusApi.Models;

namespace TrinusApi.Profiles
{
    public class OperacaoProfile : Profile
    {
        public OperacaoProfile()
        {
            CreateMap<CriarOperacaoDto, Operacao>();
            CreateMap<Operacao, LerOperacaoDto>();
            CreateMap<AtualizarOperacaoDto, Operacao>();
                

        }
           
    }
}
