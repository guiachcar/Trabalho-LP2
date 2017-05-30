using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Servico
    {
        private int _id_servico;
        private String nome;
        private String descricao;
        private float valor;

        public Servico() 
        { 
        }

        public int Id
        {
            get
            {
                return _id_servico;
            }

            set
            {
                _id_servico = value;
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

        public float Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}
