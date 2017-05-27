using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Acao
    {
        private int _id;
        private string descricao;
        private int chamado_id;
        private int funcionario_id;
        private DateTime data_acao;

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

        public int Chamado_id
        {
            get
            {
                return chamado_id;
            }

            set
            {
                chamado_id = value;
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

        public DateTime Data_acao
        {
            get
            {
                return data_acao;
            }

            set
            {
                data_acao = value;
            }
        }
    }
}
