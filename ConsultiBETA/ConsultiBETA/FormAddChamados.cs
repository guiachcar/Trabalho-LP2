using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultiBETA
{
    public partial class FormAddChamados : Form
    {
        public FormAddChamados()
        {
            InitializeComponent();
        }

        private void btnIDCliente_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }

        private void btnIDFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            form.Show();
        }

        private void btnIDVenda_Click(object sender, EventArgs e)
        {
            FormAddVendas form = new FormAddVendas();
            form.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
