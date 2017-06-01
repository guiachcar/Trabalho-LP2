using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Status
    {
        private int _id_status;
        private string status_chamado;

        public Status()
        {

        }
        public Status (int id, string status)
        {
            this.Id_status = id;
            this.Status_chamado = Status_chamado;
        }

        public int Id_status
        {
            get
            {
                return _id_status;
            }

            set
            {
                _id_status = value;
            }
        }

        public string Status_chamado
        {
            get
            {
                return status_chamado;
            }

            set
            {
                status_chamado = value;
            }
        }
    }
}
