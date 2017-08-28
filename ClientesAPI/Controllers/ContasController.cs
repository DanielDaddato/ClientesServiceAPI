using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Repositorio;
using ClientesAPI.Models;

namespace ClientesAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ContasController : Controller
    {

        [HttpGet("{*clienteID}", Name = "Get")]
        public IEnumerable<Conta> Get(Guid clienteID)
        {
            // return new ContasRepositorio().BuscarPorCliente(clienteID);
            return null;
        }
        
        // POST: api/Contas
        [HttpPost]
        public void Post([FromBody]Conta conta)
        {
            //new ContasRepositorio().Adicionar(conta);
        }
        
        // PUT: api/Contas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Conta conta)
        {
           // new ContasRepositorio().Editar(conta);
        }
    }
}
