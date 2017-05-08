﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Funcionario: Pessoa
    {
        private String cargo;
        private float salario;

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

        public float Salario
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
    }
}