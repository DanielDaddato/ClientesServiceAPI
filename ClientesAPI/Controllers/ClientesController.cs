using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Models;
using ClientesAPI.Repositorio;

namespace ClientesAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            //var clientes = new ClientesRepositorio().Listar();

            //return clientes;
            return null;
        }

        
        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody]Cliente cliente)
        {
            //var clientes = new ClientesRepositorio().Adicionar(cliente);
        }
        
    }
}
