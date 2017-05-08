using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Venda
    {
        private int _id;
        private List<Produto> produtos;
        private List<Servico> servicos;
        private float valor_total;
        private int status;

        public Venda()
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

        internal List<Produto> Produtos
        {
            get
            {
                return produtos;
            }

            set
            {
                produtos = value;
            }
        }

        internal List<Servico> Servicos
        {
            get
            {
                return servicos;
            }

            set
            {
                servicos = value;
            }
        }

        public float Valor_total
        {
            get
            {
                return valor_total;
            }

            set
            {
                valor_total = value;
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
