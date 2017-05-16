using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;

namespace ConsultiBETA.Controller
{
    class ServicoController
    {
        public void Cadastrar(Servico servico)
        {
            Listas.servicos.Add(servico);
        }
        public void Excluir(Servico servico)
        {
            Listas.servicos.Remove(servico);
        }
        public Servico getServico(int id)
        {
            return Listas.servicos[id];
        }
        public List<Servico> Listar()
        {
            return Listas.servicos;
        }
    }
}
