using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Chamado : Venda
    {
        private int _id_chamado;
        private Cliente cliente;
        private Funcionario funcionario;
        private List<Acao> acao;
        private string descricao;
        private Status status;
        private DateTime data_abertura;
        private DateTime data_agendamento;

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

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        internal Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }

        internal List<Acao> Acao
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        internal Status Status1
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
    }
}
