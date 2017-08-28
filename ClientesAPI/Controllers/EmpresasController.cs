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
    public class EmpresasController : Controller
    {
        // GET: api/Empresas/5
        [HttpGet("{*codigo}", Name = "Get")]
        public IEnumerable<Empresa> Get(string codigo)
        {
            return null;//return new EmpresaServico().BuscarEmpresa(codigo);
        }
    }
}
