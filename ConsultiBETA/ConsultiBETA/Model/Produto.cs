using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Produto
    {
        private int _id;
        private String nome;
        private String tipo;
        private String descricao;
        private float valor_venda;
        private float valor_compra;
        private int quantidade;

        public Produto()
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

        public float Valor_venda
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

        public float Valor_compra
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
    }
}
