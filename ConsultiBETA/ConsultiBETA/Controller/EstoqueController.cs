using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Controller;
using ConsultiBETA.Model;
using System.Windows.Forms;
using System.Data;

namespace ConsultiBETA.Controller
{
    class EstoqueController:Controller
    {
        public void Cadastrar(Estoque estoque)
        {
            string sqlQuery = "INSERT INTO estoque (produto_id,quantidade) VALUES ('" + estoque.Id + "'," + estoque.Quantidade + ")";
            int idCadastrado = ExecutarSql(sqlQuery);
        }
        public void Excluir(Estoque estoque)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o produto do estoque?", "Excluir estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM estoque WHERE _id_estoque=" + estoque.Id;
                ExecutarSql(sqlQuery);
            }

        }
        public void Editar(Estoque estoque)
        {
            string sqlQuery = "UPDATE estoque SET quantidade=" + estoque.Quantidade+ " WHERE _id_estoque=" + estoque.Id;
            ExecutarSql(sqlQuery);
        }

        public Estoque getEstoque(int id)
        {
            DataRow estoqueRow;
            string sqlQuery = "SELECT * FROM estoque e RIGHT JOIN produto p ON p._id_produto=e.produto_id WHERE p._id_produto=" + id;
            estoqueRow = ExecutarSqlRetornoObj(sqlQuery);
            Estoque estoque = new Estoque();
            estoque.Id = estoqueRow.Field<int>("produto_id");
            estoque.Nome = estoqueRow.Field<string>("nome");
            estoque.Quantidade = estoqueRow.Field<int>("quantidade");
            return estoque;
        }

        public DataSet Listar()
        {
            string table = "estoque";
            string sqlQuery = "SELECT * FROM estoque e RIGHT JOIN produto p ON p._id_produto=e.produto_id";
            return ExecutarSqlRetGrid(sqlQuery, table);
        }
        public DataSet BuscarEstoque(string consulta)
        {
            string table = "estoque";
            string sqlQuery = "SELECT * FROM estoque e RIGHT JOIN produto p ON p._id_produto=e.produto_id WHERE nome LIKE '%" + consulta + "%' OR tipo LIKE '%" + consulta + "%' OR descricao LIKE '%" + consulta + "%'";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}
