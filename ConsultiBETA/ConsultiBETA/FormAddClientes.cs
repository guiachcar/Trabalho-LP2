using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Model;
using ConsultiBETA.Controller;

namespace ConsultiBETA
{
    public partial class FormAddClientes : Form
    {

        ClienteController clientes = new ClienteController();
        public FormAddClientes()
        {
            InitializeComponent();
        }

        private void btnSalver_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtRua.Text;
            cliente.Nro = txtNro.Text;
            cliente.Cep = txtCEP.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Uf = cbEstado.Text;

            clientes.Cadastrar(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK);
            this.Close();
            FormClientes c = Application.OpenForms["FormClientes"] as FormClientes;

            if(c != null)
            {
                c.Exibir();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
