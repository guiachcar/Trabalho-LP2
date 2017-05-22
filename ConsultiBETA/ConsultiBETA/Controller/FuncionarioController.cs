using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ConsultiBETA.Controller
{
    class FuncionarioController:Controller
    {
        
        public void Cadastrar(Funcionario funcionario)
        {
            string sqlQuery = "INSERT INTO pessoa (nome,endereco,nro,bairro,cidade,uf,telefone,cpf)" + "VALUES('" + funcionario.Nome + "','" + funcionario.Endereco + "','" + funcionario.Nro + "','" + funcionario.Bairro + "','" + funcionario.Cidade + "','" + funcionario.Uf + "','" + funcionario.Telefone + "','" + funcionario.Cpf + "')";
            int idCadastrado = ExecutarSql(sqlQuery);
            string sqlQuery1 = "INSERT INTO funcionario (pessoa_id,cargo,salario)" + "VALUES('" + idCadastrado + "','" + funcionario.Cargo + "','" + funcionario.Salario + "')";
            int idCadastrado1 = ExecutarSql(sqlQuery1);

        }
        public void Excluir(Funcionario funcionario)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o Funcionário?", "Excluir funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM funcionario WHERE pessoa_id=" + funcionario.Id;
                ExecutarSql(sqlQuery);
                string sqlQuery1 = "DELETE FROM funcionario WHERE _id=" + funcionario.Id;
                ExecutarSql(sqlQuery1);
            }
            
        }
        public void Editar(Funcionario funcionario)
        {
            string sqlQuery = "UPDATE pessoa SET nome='" + funcionario.Nome + "',endereco='" + funcionario.Endereco + "',nro='" + funcionario.Nro + "',bairro='" + funcionario.Bairro + "',cidade='" + funcionario.Cidade + "',uf='" + funcionario.Uf + "',telefone='" + funcionario.Telefone + "',cpf='" + funcionario.Cpf + "' WHERE _id=" + funcionario.Id;
            ExecutarSql(sqlQuery);
            string sqlQuery1 = "UPDATE funcionario SET salario=" + funcionario.Salario + ",cargo='" + funcionario.Cargo + "' WHERE pessoa_id=" + funcionario.Id;
            ExecutarSql(sqlQuery1);
        }
        public Funcionario getFunc(int id)
        {
            DataRow funcionarioRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id=f.pessoa_id  WHERE p._id=" + id;
            funcionarioRow = ExecutarSqlRetornoObj(sqlQuery);
            Funcionario funcionario = new Funcionario();
            funcionario.Id= funcionarioRow.Field<int>("_id");
            funcionario.Nome = funcionarioRow.Field<string>("nome");
            funcionario.Endereco = funcionarioRow.Field<string>("endereco");
            funcionario.Nro = funcionarioRow.Field<string>("nro");
            funcionario.Bairro = funcionarioRow.Field<string>("bairro");
            funcionario.Cidade = funcionarioRow.Field<string>("cidade");
            funcionario.Uf = funcionarioRow.Field<string>("uf");
            funcionario.Telefone = funcionarioRow.Field<string>("telefone");
            funcionario.Cpf = funcionarioRow.Field<string>("cpf");
            funcionario.Cargo = funcionarioRow.Field<string>("cargo");
            funcionario.Salario = funcionarioRow.Field<float>("salario");
            return funcionario;
        }

        public DataSet Listar()
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id=f.pessoa_id";
            return ExecutarSqlRetGrid(sqlQuery, table);
            
        }
    }
}
