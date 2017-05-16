using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;

namespace ConsultiBETA.Controller
{
    class ClienteController
    {
        public void Cadastrar(Cliente cliente)
        {
            Listas.clientes.Add(cliente);
        }
        public void Excluir(Cliente cliente)
        {
            Listas.clientes.Remove(cliente);
        }
        public Cliente getCliente(int id)
        {
            return Listas.clientes[id];
        }
        public List<Cliente> Listar()
        {
            return Listas.clientes;
        }
    }
}
