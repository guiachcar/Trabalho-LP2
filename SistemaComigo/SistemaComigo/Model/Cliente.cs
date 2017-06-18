using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComigo.Model
{
    class Cliente
    {
        private int id;
        private string razaosocial;
        private string endereco;
        private string cidade;
        private string estado;
        private string cep;
        private Int64 inscricao;
        private string fone;
        private string fax;
        private string email;
        private string contato;
        private string cpfcnpj;

        public Cliente() { }

        public Cliente(int id, string razaosocial, string endereco, string cidade, string estado, string cep, long inscricao, string fone, string fax, string email, string contato, string cpfcnpj)
        {
            this.id = id;
            this.razaosocial = razaosocial;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.inscricao = inscricao;
            this.fone = fone;
            this.fax = fax;
            this.email = email;
            this.contato = contato;
            this.cpfcnpj = cpfcnpj;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Razaosocial
        {
            get
            {
                return razaosocial;
            }

            set
            {
                razaosocial = value;
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

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public long Inscricao
        {
            get
            {
                return inscricao;
            }

            set
            {
                inscricao = value;
            }
        }

        public string Fone
        {
            get
            {
                return fone;
            }

            set
            {
                fone = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Contato
        {
            get
            {
                return contato;
            }

            set
            {
                contato = value;
            }
        }

        public string Cpfcnpj
        {
            get
            {
                return cpfcnpj;
            }

            set
            {
                cpfcnpj = value;
            }
        }
    }
}
