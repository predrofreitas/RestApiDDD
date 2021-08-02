using AutoMapper;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Aplicacao.Interfaces;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using RestApiDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace RestApiDDD.Aplicacao
{
    public class AplicacaoServicoCliente : IAplicacaoServicoCliente
    {
        private readonly IServicoCliente _servicoCliente;
        private readonly IMapper _mapper;

        public AplicacaoServicoCliente(IServicoCliente servicoCliente, IMapper mapper)
        {
            _servicoCliente = servicoCliente;
            _mapper = mapper;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _servicoCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _servicoCliente.GetAll();
            var clientesDto = _mapper.Map<IEnumerable<ClienteDto>>(clientes);

            return clientesDto;
        }

        public ClienteDto GetById(int id)
        {
            var cliente = _servicoCliente.GetById(id);
            var clienteDto = _mapper.Map<ClienteDto>(cliente);

            return clienteDto;
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _servicoCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _servicoCliente.Update(cliente);
        }
    }
}
