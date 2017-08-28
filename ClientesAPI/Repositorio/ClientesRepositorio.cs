using ClientesAPI.Data;
using ClientesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesAPI.Repositorio
{
    public class ClientesRepositorio
    {
        public int Adicionar(Cliente cliente)
        {
            using (var context = new  ClientesDBContext())
            {
                context.Clientes.Add(cliente);
                return context.SaveChanges();
            }
        }

        public IEnumerable<Cliente> Listar()
        {
            using (var context = new ClientesDBContext())
            {
                return context.Clientes.ToList();
            }
        }

    }
}
