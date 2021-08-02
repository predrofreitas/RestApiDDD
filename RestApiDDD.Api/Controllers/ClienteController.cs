using Microsoft.AspNetCore.Mvc;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IAplicacaoServicoCliente _aplicacaoServicoCliente;


        public ClientesController(IAplicacaoServicoCliente aplicacaoServicoCliente)
        {
            _aplicacaoServicoCliente = aplicacaoServicoCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicacaoServicoCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicacaoServicoCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServicoCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServicoCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServicoCliente.Remove(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}