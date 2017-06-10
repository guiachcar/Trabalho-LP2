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
            string sqlQuery = "INSERT INTO funcionario (pessoa_id,cargo,salario,senha)" + "VALUES('" + idCadastrado + "','" + funcionario.Cargo + "', REPLACE('" + funcionario.Salario.ToString() + "',',','.'),'" + funcionario.Senha + "')";
            int idCadastrado1 = ExecutarSql(sqlQuery);

        }
        public void Excluir(Funcionario funcionario)
        {
            
                string sqlQuery = "DELETE FROM funcionario WHERE pessoa_id=" + funcionario.Id;
                ExecutarSql(sqlQuery);
                controllerPessoa.ExcluirPessoa(funcionario);
            
        }
        public void Editar(Funcionario funcionario)
        {
            controllerPessoa.EditarPessoa(funcionario);
            string sqlQuery = "UPDATE funcionario SET salario=REPLACE('" + funcionario.Salario.ToString() + "',',','.') , cargo='"+ funcionario.Cargo + "', senha = '" + funcionario.Senha + "' WHERE pessoa_id=" + funcionario.Id;
            ExecutarSql(sqlQuery);
        }
        public Funcionario getFunc(int id)
        {
            DataRow funcionarioRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa=f.pessoa_id  WHERE f.pessoa_id=" + id;
            funcionarioRow = ExecutarSqlRetornoObj(sqlQuery);
            Funcionario funcionario = new Funcionario();
            funcionario.Id= funcionarioRow.Field<int>("pessoa_id");
            funcionario.Nome = funcionarioRow.Field<string>("nome");
            funcionario.Endereco = funcionarioRow.Field<string>("endereco");
            funcionario.Nro = funcionarioRow.Field<string>("nro");
            funcionario.Bairro = funcionarioRow.Field<string>("bairro");
            funcionario.Cidade = funcionarioRow.Field<string>("cidade");
            funcionario.Uf = funcionarioRow.Field<string>("uf");
            funcionario.Cep = funcionarioRow.Field<string>("cep");
            funcionario.Telefone = funcionarioRow.Field<string>("telefone");
            funcionario.Cpf = funcionarioRow.Field<string>("cpf");
            funcionario.Cargo = funcionarioRow.Field<string>("cargo");
            funcionario.Salario = funcionarioRow.Field<decimal>("salario");
            funcionario.Senha = funcionarioRow.Field<string>("senha");
            return funcionario;
        }

        public DataSet Listar()
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa=f.pessoa_id";
            return ExecutarSqlRetGrid(sqlQuery, table);
            
        }
        public DataSet ListarTecnicos()
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa=f.pessoa_id WHERE f.cargo='Tecnico' ORDER BY p.nome ASC";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public bool verificarLogin(string cpf, string senha)
        {
            DataRow funcionarioRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa=f.pessoa_id WHERE p.cpf='" + cpf + "' AND f.senha='" + senha + "'";
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
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa = f.pessoa_id  WHERE p.cpf='" + cpf+"'";
            funcionarioRow = ExecutarSqlRetornoObj(sqlQuery);
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcionarioRow.Field<int>("_id_pessoa");
            funcionario.Nome = funcionarioRow.Field<string>("nome");
            funcionario.Endereco = funcionarioRow.Field<string>("endereco");
            funcionario.Nro = funcionarioRow.Field<string>("nro");
            funcionario.Bairro = funcionarioRow.Field<string>("bairro");
            funcionario.Cidade = funcionarioRow.Field<string>("cidade");
            funcionario.Uf = funcionarioRow.Field<string>("uf");
            funcionario.Cep = funcionarioRow.Field<string>("cep");
            funcionario.Telefone = funcionarioRow.Field<string>("telefone");
            funcionario.Cpf = funcionarioRow.Field<string>("cpf");
            funcionario.Cargo = funcionarioRow.Field<string>("cargo");
            funcionario.Salario = funcionarioRow.Field<decimal>("salario");
            funcionario.Senha = funcionarioRow.Field<string>("senha");
            return funcionario;
        }
        public DataSet BuscarFuncionario(string consulta)
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN funcionario f ON p._id_pessoa=f.pessoa_id WHERE p.nome LIKE '%" + consulta + "%' OR p.cpf LIKE '%" + consulta + "%' OR p.endereco LIKE '%" + consulta + "%' OR p.cidade LIKE '%" + consulta + "%' OR f.cargo LIKE '%"+consulta+"%'";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }

    }
}
