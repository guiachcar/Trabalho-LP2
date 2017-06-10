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
        StatusController controllerStatus = new StatusController();

        public DataSet Listar()
        {
            string table = "venda";
            string sqlQuery = "SELECT * FROM venda ve INNER JOIN chamado ch ON ve._id_venda = ch.venda_id INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status;";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public void Finalizar(int id,DateTime data_pagamento)
        {
            ExecutarSql("UPDATE venda SET status_venda=4, data_pagamento ='"+data_pagamento.ToString("yyyy-MM-dd")+"' WHERE _id_venda=" + id);
        }
        public Venda GetVenda(int id)
        {
            DataRow vendaRow;
            string sqlQuery = "SELECT * FROM venda WHERE _id_venda=" + id + ";";
            vendaRow = ExecutarSqlRetornoObj(sqlQuery);
            Venda venda = new Venda();
            venda.Id = vendaRow.Field<int>("_id_venda");
            venda.Valor_total = vendaRow.Field<decimal>("valor_total");
            venda.Status_Venda = controllerStatus.GetStatus(vendaRow.Field<int>("status_venda"));
            //if(vendaRow.Field<DateTime>("data_pagamento") != null)
              //  venda.Data_pagamento = vendaRow.Field<DateTime>("data_pagamento");
            return venda;
        }
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
                produto.Venda =  GetVenda(x.Field<int>("venda_id"));
                produtos.Add(produto);
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
                servico.Venda = GetVenda(x.Field<int>("venda_id"));
                servicos.Add(servico);
            }
            return servicos;
        }
        public DataSet BuscarVenda(string consulta)
        {
            string table = "venda";
            string sqlQuery = "SELECT * FROM venda ve INNER JOIN chamado ch ON ve._id_venda = ch.venda_id INNER JOIN pessoa pe ON ch.cliente_id=pe._id_pessoa INNER JOIN status st ON st._id_status=ch.status WHERE pe.nome LIKE '%"+consulta+"%' OR ch._id_chamado LIKE '%"+consulta+"%' OR pe.cidade LIKE '%"+consulta+"%';";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}
