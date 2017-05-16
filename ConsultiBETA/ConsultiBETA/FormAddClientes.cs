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
        public FormAddClientes(DataGridView form1)
        {
            Cliente cliente = Listas.clientes[form1.CurrentRow.Index];
            InitializeComponent();
            lbID.Text = cliente.Id.ToString();
            txtCPF.SelectedText = cliente.Cpf;
            txtNome.SelectedText = cliente.Nome;
            txtRua.SelectedText = cliente.Endereco;
            txtNro.SelectedText = cliente.Nro;
            txtBairro.SelectedText = cliente.Bairro;
            txtCidade.SelectedText = cliente.Cidade;
            cbEstado.SelectedItem = cliente.Uf;
            txtCEP.SelectedText = cliente.Cep;
            txtTelefone.SelectedText = cliente.Telefone;

        }


        private void btnSalver_Click(object sender, EventArgs e)
        {

            if (lbID.Text is "Cliente ID")
            {
                Cliente cliente = new Cliente();

                cliente.Id = Listas.clientes.Count + 1;
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
                MessageBox.Show("Cliente cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormClientes c = Application.OpenForms["FormClientes"] as FormClientes;

                if (c != null)
                {
                    c.Exibir();
                }
            }
            else{

                int id = int.Parse(lbID.Text) - 1;
                Listas.clientes[id].Cpf = txtCPF.Text;
                Listas.clientes[id].Nome = txtNome.Text;
                Listas.clientes[id].Endereco = txtRua.Text;
                Listas.clientes[id].Nro = txtNro.Text;
                Listas.clientes[id].Bairro = txtBairro.Text;
                Listas.clientes[id].Cidade = txtCidade.Text;
                Listas.clientes[id].Uf = cbEstado.Text;
                Listas.clientes[id].Cep = txtCEP.Text;
                Listas.clientes[id].Telefone = txtTelefone.Text;

                MessageBox.Show("Cliente Alterado com sucesso", "Consulti", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
                FormClientes c = Application.OpenForms["FormClientes"] as FormClientes;

                if (c != null)
                {
                    c.Exibir();
                }
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
