using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComigo.Model
{
    class Pedido
    {
        private int id;
        private DateTime dataemissao;
        private Cliente cliente;
        private string condpgto;
        private string formapgto;
        private string dtdeter;
        private string tipofrete;
        private decimal pesotbruto;
        private int pesotliq;
        private string obspedido;
        private string obsentrega;
        private string obsnota;
        private int status;
        private int status_entrega;
        private string notafiscal;
        private DateTime data_nf;

        public Pedido()
        {

        }

        public Pedido(int id, DateTime dataemissao, int cliente_id, string condpgto, string formapgto, string dtdeter, string tipofrete, decimal pesotbruto, int pesotliq, string obspedido, string obsentrega, string obsnota, int status, int status_entrega, string notafiscal, DateTime data_nf)
        {
            this.id = id;
            this.dataemissao = dataemissao;
            this.cliente_id = cliente_id;
            this.condpgto = condpgto;
            this.formapgto = formapgto;
            this.dtdeter = dtdeter;
            this.tipofrete = tipofrete;
            this.pesotbruto = pesotbruto;
            this.pesotliq = pesotliq;
            this.obspedido = obspedido;
            this.obsentrega = obsentrega;
            this.obsnota = obsnota;
            this.status = status;
            this.status_entrega = status_entrega;
            this.notafiscal = notafiscal;
            this.data_nf = data_nf;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime Dataemissao
        {
            get
            {
                return dataemissao;
            }

            set
            {
                dataemissao = value;
            }
        }

        public int Cliente_id
        {
            get
            {
                return cliente_id;
            }

            set
            {
                cliente_id = value;
            }
        }

        public string Condpgto
        {
            get
            {
                return condpgto;
            }

            set
            {
                condpgto = value;
            }
        }

        public string Formapgto
        {
            get
            {
                return formapgto;
            }

            set
            {
                formapgto = value;
            }
        }

        public string Dtdeter
        {
            get
            {
                return dtdeter;
            }

            set
            {
                dtdeter = value;
            }
        }

        public string Tipofrete
        {
            get
            {
                return tipofrete;
            }

            set
            {
                tipofrete = value;
            }
        }

        public decimal Pesotbruto
        {
            get
            {
                return pesotbruto;
            }

            set
            {
                pesotbruto = value;
            }
        }

        public int Pesotliq
        {
            get
            {
                return pesotliq;
            }

            set
            {
                pesotliq = value;
            }
        }

        public string Obspedido
        {
            get
            {
                return obspedido;
            }

            set
            {
                obspedido = value;
            }
        }

        public string Obsentrega
        {
            get
            {
                return obsentrega;
            }

            set
            {
                obsentrega = value;
            }
        }

        public string Obsnota
        {
            get
            {
                return obsnota;
            }

            set
            {
                obsnota = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Status_entrega
        {
            get
            {
                return status_entrega;
            }

            set
            {
                status_entrega = value;
            }
        }

        public string Notafiscal
        {
            get
            {
                return notafiscal;
            }

            set
            {
                notafiscal = value;
            }
        }

        public DateTime Data_nf
        {
            get
            {
                return data_nf;
            }

            set
            {
                data_nf = value;
            }
        }
    }
}
