using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;

namespace ConsultiBETA.Controller
{
    class VendaController:Controller
    {
        ProdutoController controllerProduto = new ProdutoController();
        ServicoController controllerServico = new ServicoController();

        public List<ItemVendaProduto> getProdutoList(int id)
        {
            List<DataRow> produtosRow;
            string sqlQuery = "SELECT * FROM item_venda_produto WHERE venda_id=" + id + ";";
            produtosRow = ExecutarSqlRetorno(sqlQuery);
            List<ItemVendaProduto> produtos = new List<ItemVendaProduto>();
            foreach(DataRow x in produtosRow)
            {
                ItemVendaProduto produto = new ItemVendaProduto();
                produto.Id_item_venda_produto = x.Field<int>("_id_item_venda_produto");
                produto.Produto = controllerProduto.getProduto(x.Field<int>("produto_id"));
                produto.Quantidade = x.Field<int>("quantidade");
                produto.Venda_id = x.Field<int>("venda_id");
            }
            return produtos;
        }

        public List<ItemVendaServico> getServicoList(int id)
        {
            List<DataRow> servicoRow;
            string sqlQuery = "SELECT * FROM item_venda_servico WHERE venda_id=" + id + ";";
            servicoRow = ExecutarSqlRetorno(sqlQuery);
            List<ItemVendaServico> servicos = new List<ItemVendaServico>();
            foreach (DataRow x in servicoRow)
            {
                ItemVendaServico servico = new ItemVendaServico();
                servico.Id_item_venda_servico = x.Field<int>("_id_item_venda_servico");
                servico.Servico = controllerServico.getServico(x.Field<int>("servico_id"));
                servico.Quantidade = x.Field<int>("quantidade");
                servico.Venda_id = x.Field<int>("venda_id");
            }
            return servicos;
        }
    }
}
