using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Produto
    {
        private int _id_produto;
        private string nome;
        private string tipo;
        private string descricao;
        private decimal valor_venda;
        private decimal valor_compra;
        

        public Produto()
        {

        }

        public int Id
        {
            get
            {
                return _id_produto;
            }

            set
            {
                _id_produto = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
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

        public decimal Valor_venda
        {
            get
            {
                return valor_venda;
            }

            set
            {
                valor_venda = value;
            }
        }

        public decimal Valor_compra
        {
            get
            {
                return valor_compra;
            }

            set
            {
                valor_compra = value;
            }
        }
        
    }
}
