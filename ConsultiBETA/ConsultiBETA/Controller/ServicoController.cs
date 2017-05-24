using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;

namespace ConsultiBETA.Controller
{
    class ServicoController:Controller
    {
        public void Cadastrar(Servico servico)
        {
            string sqlQuery = "INSERT INTO servico (nome,descricao,valor)" + "VALUES('" + servico.Nome + "','" + servico.Descricao + "','" + servico.Valor + "')";
            int idCadastrado = ExecutarSql(sqlQuery);
        }
        public void Excluir(Servico servico)
        {
            Listas.servicos.Remove(servico);
        }
        public Servico getServico(int id)
        {
            return Listas.servicos[id];
        }
        public List<Servico> Listar()
        {
            return Listas.servicos;
        }
    }
}
