using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;

namespace ConsultiBETA.Controller
{
    class PessoaController:Controller
    {
        public PessoaController() {

        }
        public int Cadastrar(Pessoa pessoa) {
            string sqlQuery = "INSERT INTO pessoa (nome,endereco,nro,bairro,cidade,uf,telefone,cpf)" + "VALUES('" + pessoa.Nome + "','" + pessoa.Endereco + "','" + pessoa.Nro + "','" + pessoa.Bairro + "','" + pessoa.Cidade + "','" + pessoa.Uf + "','" + pessoa.Telefone + "','" + pessoa.Cpf + "')";
            int idCadastrado = ExecutarSql(sqlQuery);
            return idCadastrado;
        }
        public void EditarPessoa(Pessoa pessoa) {
            string sqlQuery = "UPDATE pessoa SET nome='" + pessoa.Nome + "',endereco='" + pessoa.Endereco + "',nro='" + pessoa.Nro + "',bairro='" + pessoa.Bairro + "',cidade='" + pessoa.Cidade + "',uf='" + pessoa.Uf + "',telefone='" + pessoa.Telefone + "',cpf='" + pessoa.Cpf + "' WHERE _id=" + pessoa.Id;
            ExecutarSql(sqlQuery);
        }
        public void ExcluirPessoa(Pessoa pessoa) {
            string sqlQuery = "DELETE FROM pessoa WHERE _id=" + pessoa.Id;
            ExecutarSql(sqlQuery);
        }

        public List<Pessoa> ListarTodas() {
            List<Pessoa> pessoas = null;
            return pessoas;
        }
        public Pessoa GetPessoa(int _id) {
            Pessoa pessoa = new Pessoa();
            return pessoa;
        }
    }
}
