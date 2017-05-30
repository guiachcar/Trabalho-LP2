using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Controller
{
    class HistoricoController:Controller
    {
        public DataSet Listar()
        {
            string table = "historico";
            string sqlQuery = "SELECT h._id_historico,p.nome,h.query,h.horario FROM historico h INNER JOIN funcionario f  ON h.funcionario_id=f._id_funcionario INNER JOIN pessoa p ON p._id_pessoa=f.pessoa_id ORDER BY h._id_historico DESC";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
    }
}
