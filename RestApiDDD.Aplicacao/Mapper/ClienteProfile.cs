using AutoMapper;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Dominio.Entidades;

namespace RestApiDDD.Aplicacao.Mapper
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteDto, Cliente>().ReverseMap();
        }
    }
}
