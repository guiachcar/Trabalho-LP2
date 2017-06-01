using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;

namespace ConsultiBETA.Controller
{
    class AcaoController:Controller
    {
        FuncionarioController controllerFuncionario = new FuncionarioController();

        public List<Acao> getAcoes(int id)
        {
            List<DataRow> acaoRow;
            string sqlQuery = "SELECT * FROM acao WHERE chamado_id=" + id + ";";
            acaoRow = ExecutarSqlRetorno(sqlQuery);
            List<Acao> acoes = new List<Acao>();
            foreach (DataRow x in acaoRow)
            {
                Acao acao = new Acao();
                acao.Id = x.Field<int>("_id_acao");
                acao.Descricao = x.Field<string>("descricao");
                acao.Funcionario = controllerFuncionario.getFunc(x.Field<int>("funcionario_id"));
                acao.Data_acao = DateTime.Parse(x.Field<string>("data_acao"));
            }
            return acoes;
        }
    }
}
