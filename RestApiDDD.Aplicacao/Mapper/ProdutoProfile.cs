using AutoMapper;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Dominio.Entidades;

namespace RestApiDDD.Aplicacao.Mapper
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoDto, Produto>().ReverseMap();
        }
    }
}
