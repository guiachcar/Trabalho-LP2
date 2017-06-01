using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class ItemVendaProduto
    {
        private int _id_item_venda_produto;
        private Produto produto;
        private int venda_id;
        private int quantidade;

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

        public int Id_item_venda_produto
        {
            get
            {
                return _id_item_venda_produto;
            }

            set
            {
                _id_item_venda_produto = value;
            }
        }

        internal Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }
    }
}
