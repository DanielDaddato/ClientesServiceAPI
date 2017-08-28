using ClientesAPI.Data;
using ClientesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesAPI.Repositorio
{
    public class ContasRepositorio
    {
        public int Adicionar(Conta conta)
        {
            using (var context = new ClientesDBContext())
            {
                context.Contas.Add(conta);
                return context.SaveChanges();
            }
        }

        public IEnumerable<Conta> BuscarPorCliente(Guid clienteID)
        {
            using (var context = new ClientesDBContext())
            {
                return context.Contas.Where(x => x.ClienteID == clienteID).Select(x => x).ToList();
            }
        }

        public int Editar(Conta conta)
        {
            using (var context = new ClientesDBContext())
            {
                context.Contas.Attach(conta);
                context.Entry(conta).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
