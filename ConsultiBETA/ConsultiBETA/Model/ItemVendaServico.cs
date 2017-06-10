using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class ItemVendaServico

    {
        private int _id_item_venda_servico;
        private Servico servico;
        private Venda venda;
        private int quantidade;

        public Venda Venda
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public int Id_item_venda_servico
        {
            get
            {
                return _id_item_venda_servico;
            }

            set
            {
                _id_item_venda_servico = value;
            }
        }

        internal Servico Servico
        {
            get
            {
                return servico;
            }

            set
            {
                servico = value;
            }
        }
    }
}
