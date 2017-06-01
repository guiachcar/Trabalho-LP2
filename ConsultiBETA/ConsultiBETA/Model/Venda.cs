using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Venda
    {
        private int _id_venda;
        private List<ItemVendaProduto> produtos;
        private List<ItemVendaServico> servicos;
        private float valor_total;
        private Status status_venda;
        private DateTime data_pagamento;

        public Venda()
        {
            this.produtos = new List<ItemVendaProduto>();
            this.servicos = new List<ItemVendaServico>();
        }

        public int Id
        {
            get
            {
                return _id_venda;
            }

            set
            {
                _id_venda = value;
            }
        }

        internal List<ItemVendaProduto> Produtos
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

        internal List<ItemVendaServico> Servicos
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

        public Status Status_Venda
        {
            get
            {
                return status_venda;
            }

            set
            {
                status_venda = value;
            }
        }

        public DateTime Data_pagamento
        {
            get
            {
                return data_pagamento;
            }

            set
            {
                data_pagamento = value;
            }
        }
    }
}
