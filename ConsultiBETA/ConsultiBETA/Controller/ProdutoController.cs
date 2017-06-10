using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using ConsultiBETA.Controller;
using System.Windows.Forms;
using System.Data;

namespace ConsultiBETA.Controller
{
    class ProdutoController:Controller
    {
        EstoqueController controller = new EstoqueController();
        Estoque estoque = new Estoque();
        public void Cadastrar(Produto produto)
        {

            string sqlQuery = "INSERT INTO produto (nome,tipo,descricao,valor_venda,valor_compra) VALUES ('" + produto.Nome + "','"+produto.Tipo+"','" + produto.Descricao + "',REPLACE('" + produto.Valor_venda.ToString() + "',',','.'),REPLACE('" + produto.Valor_compra.ToString() + "',',','.'))";
            int idCadastrado = ExecutarSql(sqlQuery);
            estoque.Id = idCadastrado;
            estoque.Quantidade = 0;
            controller.Cadastrar(estoque);
        }
        public void Excluir(Produto produto)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o produto?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM produto WHERE _id_produto=" + produto.Id;
                ExecutarSql(sqlQuery);
                estoque = controller.getEstoque(produto.Id);
                controller.Excluir(estoque);
            }

        }
        public void Editar(Produto produto)
        {
            string sqlQuery = "UPDATE produto SET nome='" + produto.Nome + "',tipo='"+ produto.Tipo +"', descricao='" + produto.Descricao + "',valor_venda= REPLACE('" + produto.Valor_venda.ToString() + "',',','.') , valor_compra=REPLACE('" + produto.Valor_compra.ToString() + "',',','.') WHERE _id_produto=" + produto.Id;
            ExecutarSql(sqlQuery);
        }

        public Produto getProduto(int id)
        {
            DataRow produtoRow;
            string sqlQuery = "SELECT * FROM produto WHERE _id_produto=" + id;
            produtoRow = ExecutarSqlRetornoObj(sqlQuery);
            Produto produto = new Produto();
            produto.Id = produtoRow.Field<int>("_id_produto");
            produto.Nome = produtoRow.Field<string>("nome");
            produto.Tipo = produtoRow.Field<string>("tipo");
            produto.Descricao = produtoRow.Field<string>("descricao");
            produto.Valor_venda = produtoRow.Field<decimal>("valor_venda");
            produto.Valor_compra = produtoRow.Field<decimal>("valor_compra");
            return produto;
        }

        public DataSet Listar()
        {
            string table = "produto";
            string sqlQuery = "SELECT * FROM produto";
            return ExecutarSqlRetGrid(sqlQuery, table);
        }
        public DataSet ListarComEstoque()
        {
            string table = "produto";
            string sqlQuery = "SELECT * FROM produto pr INNER JOIN estoque es ON pr._id_produto=es.produto_id WHERE quantidade>0";
            return ExecutarSqlRetGrid(sqlQuery, table);
        }
        public DataSet BuscarProduto(string consulta)
        {
            string table = "produto";
            string sqlQuery = "SELECT * FROM produto WHERE nome LIKE '%" + consulta + "%' OR tipo LIKE '%" + consulta + "%' OR descricao LIKE '%"+consulta+"%'";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}
