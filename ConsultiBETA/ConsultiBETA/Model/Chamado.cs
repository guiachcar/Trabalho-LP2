using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Chamado
    {
        private int _id;
        private int cliente_id;
        private int funcionario_id;
        private int venda_id;
        private List<String> acao;
        private int status;

        public Chamado()
        {

        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
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

        public List<string> Acao
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
    }
}
