using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Estoque:Produto
    {
        private int quantidade;

        public Estoque()
        {

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
