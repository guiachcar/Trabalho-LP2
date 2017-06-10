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
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    break;
                case "Administrativo":
                    break;
                case "Estoquista":
                    btnNovo.Visible = false;
                    btnEditar.Text = "Visualizar";
                    break;
                case "Gerencia":
                    break;
                case "Técnico":
                    btnNovo.Visible = false;
                    btnEditar.Text = "Visualizar";
                    break;
            }
        }

        public void Exibir()
        {
            dgClientes.DataSource = controller.Listar();
            dgClientes.DataMember = "pessoa";
            dgClientes.Columns[0].Visible = false;
            dgClientes.Columns[1].HeaderText = "Nome";
            dgClientes.Columns[2].HeaderText = "Endereço";
            dgClientes.Columns[3].HeaderText = "Número";
            dgClientes.Columns[4].Visible = false;
            dgClientes.Columns[5].HeaderText = "Cidade";
            dgClientes.Columns[6].HeaderText = "Estado";
            dgClientes.Columns[7].Visible = false;
            dgClientes.Columns[8].HeaderText = "Telefone";
            dgClientes.Columns[9].Visible = false;
            dgClientes.Columns[10].Visible = false;
            dgClientes.Columns[11].Visible = false;

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
