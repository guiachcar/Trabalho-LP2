using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;

namespace ConsultiBETA.Controller
{
    class PessoaController:Controller
    {
        public PessoaController() {

        }
        public int Cadastrar(Pessoa pessoa) {
            string sqlQuery = "INSERT INTO pessoa (nome,endereco,nro,bairro,cidade,uf,cep,telefone,cpf)" + "VALUES('" + pessoa.Nome + "','" + pessoa.Endereco + "','" + pessoa.Nro + "','" + pessoa.Bairro + "','" + pessoa.Cidade + "','" + pessoa.Uf + "','"+pessoa.Cep+"','" + pessoa.Telefone + "','" + pessoa.Cpf + "')";
            int idCadastrado = ExecutarSql(sqlQuery);
            return idCadastrado;
        }
        public void EditarPessoa(Pessoa pessoa) {
            string sqlQuery = "UPDATE pessoa SET nome='" + pessoa.Nome + "',endereco='" + pessoa.Endereco + "',nro='" + pessoa.Nro + "',bairro='" + pessoa.Bairro + "',cidade='" + pessoa.Cidade + "',uf='" + pessoa.Uf + "', cep='"+pessoa.Cep+"',telefone='" + pessoa.Telefone + "',cpf='" + pessoa.Cpf + "' WHERE _id_pessoa=" + pessoa.Id;
            ExecutarSql(sqlQuery);
        }
        public void ExcluirPessoa(Pessoa pessoa) {
            string sqlQuery = "DELETE FROM pessoa WHERE _id_pessoa=" + pessoa.Id;
            ExecutarSql(sqlQuery);
        }

        
        public Pessoa GetPessoa(int id) {

            DataRow pessoaRow;
            string sqlQuery = "SELECT * FROM pessoa WHERE _id_pessoa=" + id;
            pessoaRow = ExecutarSqlRetornoObj(sqlQuery);
            Pessoa pessoa = new Pessoa();
            pessoa.Id = pessoaRow.Field<int>("_id_pessoa");
            pessoa.Nome = pessoaRow.Field<string>("nome");
            pessoa.Endereco = pessoaRow.Field<string>("endereco");
            pessoa.Nro = pessoaRow.Field<string>("nro");
            pessoa.Bairro = pessoaRow.Field<string>("bairro");
            pessoa.Cidade = pessoaRow.Field<string>("cidade");
            pessoa.Uf = pessoaRow.Field<string>("uf");
            pessoa.Cep = pessoaRow.Field<string>("cep");
            pessoa.Telefone = pessoaRow.Field<string>("telefone");
            pessoa.Cpf = pessoaRow.Field<string>("cpf");
            return pessoa;
        }
    }
}
