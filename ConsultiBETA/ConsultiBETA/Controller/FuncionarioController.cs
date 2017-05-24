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

        PessoaController controllerPessoa = new PessoaController();

        public void Cadastrar(Funcionario funcionario)
        {
            Pessoa pessoa = new Pessoa();
            pessoa = funcionario;
            int idCadastrado = controllerPessoa.Cadastrar(pessoa);
            string sqlQuery = "INSERT INTO funcionario (pessoa_id,cargo,salario,senha)" + "VALUES('" + idCadastrado + "','" + funcionario.Cargo + "','" + funcionario.Salario + "','" + funcionario.Senha + "')";
            int idCadastrado1 = ExecutarSql(sqlQuery);

        }
        public void Excluir(Funcionario funcionario)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o Funcionário?", "Excluir funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM funcionario WHERE pessoa_id=" + funcionario.Id;
                ExecutarSql(sqlQuery);
                controllerPessoa.ExcluirPessoa(funcionario);
            }
            
        }
        public void Editar(Funcionario funcionario)
        {
            controllerPessoa.EditarPessoa(funcionario);
            string sqlQuery = "UPDATE funcionario SET salario=" + funcionario.Salario + ",cargo='" + funcionario.Cargo + "', senha = '" + funcionario.Senha + "' WHERE pessoa_id=" + funcionario.Id;
            ExecutarSql(sqlQuery);
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
        public bool verificarLogin(string cpf, string senha)
        {
            DataRow funcionarioRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id=f.pessoa_id WHERE p.cpf='" + cpf + "' AND f.senha='" + senha + "'";
            funcionarioRow = ExecutarSqlRetornoObj(sqlQuery);
            if (funcionarioRow != null)
            {
                return true;
            }
            else
                return false;
        }
        public Funcionario getFuncCPF(string cpf)
        {
            DataRow funcionarioRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id=f.pessoa_id  WHERE p.cpf=" + cpf;
            funcionarioRow = ExecutarSqlRetornoObj(sqlQuery);
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcionarioRow.Field<int>("_id");
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

    }
}
