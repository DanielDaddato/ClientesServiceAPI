using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Servico;
using ClientesAPI.Models;

namespace ClientesAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PrecosController : Controller
    {
        // GET: api/Precos/5
        [HttpGet("{*codigo}", Name = "Get")]
        public Preco Get(string codigo)
        {
            //return new EmpresaServico().BuscarPreco(codigo);
            return null;
        }

    }
}
