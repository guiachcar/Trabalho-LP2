using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultiBETA.Model
{
    class Pessoa
    {

        private int _id_pessoa;
        private String nome;
        private String endereco;
        private String nro;
        private String bairro;
        private String cidade;
        private String uf;
        private String cep;
        private String telefone;
        private String cpf;

        public Pessoa()
        {
        }

        public int Id
        {
            get
            {
                return _id_pessoa;
            }

            set
            {
                _id_pessoa = value;
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

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
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

        public string Cep { get { return cep; } set { cep = value; }
        }
    }
}
