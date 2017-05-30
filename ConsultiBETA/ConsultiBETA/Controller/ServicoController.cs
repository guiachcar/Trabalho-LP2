using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Windows.Forms;
using System.Data;

namespace ConsultiBETA.Controller
{
    class ServicoController:Controller
    {
        public void Cadastrar(Servico servico)
        {

            string sqlQuery = "INSERT INTO servico (nome,descricao,valor) VALUES ('" +servico.Nome+ "','"+ servico.Descricao +"',"+servico.Valor+")";
            int idCadastrado = ExecutarSql(sqlQuery);
        }
        public void Excluir(Servico servico)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o servico?", "Excluir servico", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM servico WHERE _id_servico=" + servico.Id;
                ExecutarSql(sqlQuery);
            }

        }
        public void Editar(Servico servico)
        {
            string sqlQuery = "UPDATE servico SET nome='" + servico.Nome + "',descricao='" + servico.Descricao + "',valor=" + servico.Valor + " WHERE _id_servico=" + servico.Id;
            ExecutarSql(sqlQuery);
        }

        public Servico getServico(int id)
        {
            DataRow servicoRow;
            string sqlQuery = "SELECT * FROM servico WHERE _id_servico=" + id;
            servicoRow = ExecutarSqlRetornoObj(sqlQuery);
            Servico servico = new Servico();
            servico.Id = servicoRow.Field<int>("_id_servico");
            servico.Nome = servicoRow.Field<string>("nome");
            servico.Descricao = servicoRow.Field<string>("descricao");
            servico.Valor = servicoRow.Field<float>("valor");
            return servico;
        }

        public DataSet Listar()
        {
            string table = "servico";
            string sqlQuery = "SELECT * FROM servico";
            return ExecutarSqlRetGrid(sqlQuery, table);
        }
        public DataSet BuscarProduto(string consulta)
        {
            string table = "produto";
            string sqlQuery = "SELECT * FROM servico WHERE nome LIKE '%" + consulta + "%' OR descricao LIKE '%";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}
