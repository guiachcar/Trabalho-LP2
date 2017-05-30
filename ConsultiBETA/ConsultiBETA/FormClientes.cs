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
        ClienteController controller = new ClienteController();
        public FormClientes()
        {
            InitializeComponent();
            Exibir();
        }

        public void Exibir()
        {
            dgClientes.DataSource = controller.Listar();
            dgClientes.DataMember = "pessoa";
            dgClientes.Columns[0].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddClientes form = new FormAddClientes();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAddClientes form = new FormAddClientes(dgClientes);
            form.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controller.Excluir(controller.getCliente(int.Parse(dgClientes.Rows[dgClientes.CurrentRow.Index].Cells[0].Value.ToString())));
            Exibir();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgClientes.DataSource = controller.BuscarCliente(txtDigiteAqui.Text);
            dgClientes.DataMember = "pessoa";

        }
    }
}
