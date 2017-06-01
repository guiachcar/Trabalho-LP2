using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;
using System.Data;

namespace ConsultiBETA.Controller
{
    class StatusController:Controller
    {
        public DataSet Listar()
        {
            string table = "status";
            string sqlQuery = "SELECT * FROM status";
            return ExecutarSqlRetGrid(sqlQuery, table);

        }
        public Status GetStatus(int id)
        {
            DataRow statusRow;
            string sqlQuery = "SELECT * FROM status WHERE _id_status=" + id + ";";
            statusRow = ExecutarSqlRetornoObj(sqlQuery);
            Status status = new Status();
            status.Id_status = statusRow.Field<int>("_id_status");
            status.Status_chamado = statusRow.Field<string>("status_chamado");
            return status;
        }
    }
}
