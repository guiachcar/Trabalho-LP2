using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Chamado
    {
        private int _id_chamado;
        private int cliente_id;
        private int funcionario_id;
        private int venda_id;
        private List<Acao> acao;
        private int status;
        private DateTime data_abertura;
        private DateTime data_agendamento;

        public Chamado()
        {

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

        public int Funcionario_id
        {
            get
            {
                return funcionario_id;
            }

            set
            {
                funcionario_id = value;
            }
        }

        public int Venda_id
        {
            get
            {
                return venda_id;
            }

            set
            {
                venda_id = value;
            }
        }

        public List<Acao> Acao
        {
            get
            {
                return acao;
            }

            set
            {
                acao = value;
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

        public DateTime Data_abertura
        {
            get
            {
                return data_abertura;
            }

            set
            {
                data_abertura = value;
            }
        }

        public DateTime Data_agendamento
        {
            get
            {
                return data_agendamento;
            }

            set
            {
                data_agendamento = value;
            }
        }

        public int Id_chamado
        {
            get
            {
                return _id_chamado;
            }

            set
            {
                _id_chamado = value;
            }
        }
    }
}
