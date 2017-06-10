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
    public partial class FormViewVenda : Form
    {
        VendaController controller = new VendaController();
        public FormViewVenda()
        {
            InitializeComponent();
        }
        public FormViewVenda(DataGridView dgVendas)
        {
            InitializeComponent();
            lbId.Text = dgVendas.Rows[dgVendas.CurrentRow.Index].Cells[0].Value.ToString();
            lbCliente.Text = dgVendas.Rows[dgVendas.CurrentRow.Index].Cells[14].Value.ToString();
            lbValor.Text = dgVendas.Rows[dgVendas.CurrentRow.Index].Cells[1].Value.ToString();
            if (int.Parse(dgVendas.Rows[dgVendas.CurrentRow.Index].Cells[2].Value.ToString()) == 4)
            {
                lbDataPagamento.Text = dgVendas.Rows[dgVendas.CurrentRow.Index].Cells[3].Value.ToString();
                txtDataPagamento.Visible = false;
                btnSalvar.Visible = false;
            }
            
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            controller.Finalizar(int.Parse(lbId.Text), DateTime.Parse(txtDataPagamento.Text));
            MessageBox.Show("Venda finalizada com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            FormVenda v = Application.OpenForms["FormVenda"] as FormVenda;

            if (v != null)
            {
                v.Exibir();
            }
        }
    }
}
