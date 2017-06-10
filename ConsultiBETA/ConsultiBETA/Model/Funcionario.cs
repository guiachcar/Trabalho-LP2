using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Funcionario: Pessoa
    {
        private string cargo;
        private decimal salario;
        private string senha;

        public Funcionario() 
        {
        }
        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public decimal Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

     
    }
}
