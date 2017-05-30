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
    class ClienteController:Controller
    {

        PessoaController controllerPessoa = new PessoaController();
        public void Cadastrar(Cliente cliente)
        {

            Pessoa pessoa = new Pessoa();
            pessoa = cliente;
            int idCadastrado = controllerPessoa.Cadastrar(pessoa);
            string sqlQuery = "INSERT INTO cliente (pessoa_id) VALUES (" + idCadastrado + ")";
            int idCadastrado1 = ExecutarSql(sqlQuery);
        }
        public void Excluir(Cliente cliente)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o Cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string sqlQuery = "DELETE FROM cliente WHERE _id_cliente=" + cliente.Id ;
                ExecutarSql(sqlQuery);
                controllerPessoa.ExcluirPessoa(cliente);
            }

        }
        public void Editar(Cliente cliente)
        {
            controllerPessoa.EditarPessoa(cliente);
        }
        public Cliente getCliente(int id)
        {
            DataRow clienteRow;
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN cliente c ON p._id_pessoa=c.pessoa_id  WHERE p._id_pessoa=" + id;
            clienteRow = ExecutarSqlRetornoObj(sqlQuery);
            Cliente cliente = new Cliente();
            cliente.Id = clienteRow.Field<int>("pessoa_id");
            cliente.Nome = clienteRow.Field<string>("nome");
            cliente.Endereco = clienteRow.Field<string>("endereco");
            cliente.Nro = clienteRow.Field<string>("nro");
            cliente.Bairro = clienteRow.Field<string>("bairro");
            cliente.Cidade = clienteRow.Field<string>("cidade");
            cliente.Uf = clienteRow.Field<string>("uf");
            cliente.Telefone = clienteRow.Field<string>("telefone");
            cliente.Cpf = clienteRow.Field<string>("cpf");
            return cliente;
        }

        public DataSet Listar()
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN cliente c ON p._id_pessoa=c.pessoa_id";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        
        public DataSet BuscarCliente(string consulta)
        {
            string table = "pessoa";
            string sqlQuery = "SELECT * FROM pessoa p INNER JOIN cliente c ON p._id_pessoa=c.pessoa_id WHERE p.nome LIKE '%" + consulta+"%' OR p.cpf LIKE '%"+consulta+"%' OR p.endereco LIKE '%"+consulta+"%' OR p.cidade LIKE '%"+consulta+"%'";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}

