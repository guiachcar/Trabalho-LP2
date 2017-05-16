using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Controller;
using ConsultiBETA.Model;


namespace ConsultiBETA
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            Exibir();
        }

        public void Exibir()
        {
            dgClientes.Rows.Clear();
            foreach (Cliente c in Listas.clientes)
            {
                dgClientes.Rows.Add(c.Id, c.Nome, c.Cpf, c.Telefone, c.Endereco, c.Nro, c.Cep, c.Bairro, c.Cidade, c.Uf);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddClientes form = new FormAddClientes();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = new DataGridViewRow();
            linha = dgClientes.CurrentRow;
            FormAddClientes form = new FormAddClientes();
            form.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteController clientes = new ClienteController();
            if (dgClientes.CurrentRow != null)
            {
                clientes.Excluir(clientes.getCliente(dgClientes.CurrentRow.Index));
            }
            Exibir();
        }
    }
}
