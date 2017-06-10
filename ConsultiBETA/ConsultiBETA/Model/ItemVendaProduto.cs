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
        private Venda venda;
        private int quantidade;

        public ItemVendaProduto()
        {
        }
        public ItemVendaProduto(int _id_item_venda_produto, Produto produto, Venda venda, int quantidade)
        {
            this._id_item_venda_produto = _id_item_venda_produto;
            this.produto = produto;
            this.venda = venda;
            this.quantidade = quantidade;
        }

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
