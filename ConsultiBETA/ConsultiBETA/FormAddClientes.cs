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
            switch (FormLogin.nivelAcesso)
            {
                case "Técnico":
                    btnSalver.Visible = false;
                    break;
            }
            Cliente cliente = clientes.getCliente(int.Parse(form1.Rows[form1.CurrentRow.Index].Cells[0].Value.ToString()));
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

            Cliente cliente = new Cliente();

            if (lbID.Text == "Cliente ID")
            {
                
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

                int id = int.Parse(lbID.Text);
                cliente.Id = id;
                cliente.Cpf = txtCPF.Text;
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtRua.Text;
                cliente.Nro = txtNro.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Uf = cbEstado.Text;
                cliente.Cep = txtCEP.Text;
                cliente.Telefone = txtTelefone.Text;
                clientes.Editar(cliente);
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
