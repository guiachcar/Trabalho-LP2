using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Acao:Chamado
    {
        private int _id_acao;
        private string descricao;
        private DateTime data_acao;

        

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

        public int Id_acao
        {
            get
            {
                return _id_acao;
            }

            set
            {
                _id_acao = value;
            }
        }
    }
}
