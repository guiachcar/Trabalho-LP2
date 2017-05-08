using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Pessoa
    {

        private int _id;
        private String nome;
        private String endereco;
        private String nro;
        private String bairro;
        private String Cidade;
        private String uf;
        private String telefone;
        private String cpf;

        public Pessoa()
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

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Nro
        {
            get
            {
                return nro;
            }

            set
            {
                nro = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Cidade1
        {
            get
            {
                return Cidade;
            }

            set
            {
                Cidade = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
    }
}
