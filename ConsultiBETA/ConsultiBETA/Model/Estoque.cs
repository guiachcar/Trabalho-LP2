using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Estoque
    {
        private int _id;
        private int produto_id;
        private int quantidade;

        public Estoque()
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

        public int Produto_id
        {
            get
            {
                return produto_id;
            }

            set
            {
                produto_id = value;
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
