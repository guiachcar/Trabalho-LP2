using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using ConsultiBETA.Controller;

namespace ConsultiBETA.Controller
{
    class ProdutoController
    {
        public void Cadastrar(Produto produto)
        {
            Listas.produtos.Add(produto);
        }
        public void Excluir(Produto produto)
        {
            Listas.produtos.Remove(produto);
        }
        public Produto getProduto(int id)
        {
            return Listas.produtos[id];
        }
        public List<Produto> Listar()
        {
            return Listas.produtos;
        }
    }
}
