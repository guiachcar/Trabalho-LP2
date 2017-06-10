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
    public partial class FormVenda : Form
    {
        VendaController controller = new VendaController();
        public FormVenda()
        {
            InitializeComponent();
            Exibir();
        }
        public void Exibir()
        {
            dgVendas.DataSource = controller.Listar();
            dgVendas.DataMember = "venda";
            dgVendas.Columns[0].HeaderText = "Id";
            dgVendas.Columns[1].HeaderText = "Valor";
            dgVendas.Columns[2].HeaderText = "Status";
            dgVendas.Columns[3].HeaderText = "Data Pagamento";
            dgVendas.Columns[4].HeaderText = "Numero Chamado";
            dgVendas.Columns[5].Visible = false;
            dgVendas.Columns[6].Visible = false;
            dgVendas.Columns[7].Visible = false;
            dgVendas.Columns[8].Visible = false;
            dgVendas.Columns[9].Visible = false;
            dgVendas.Columns[10].Visible = false;
            dgVendas.Columns[11].HeaderText = "Data Abertura";
            dgVendas.Columns[12].Visible = false;
            dgVendas.Columns[13].Visible = false;
            dgVendas.Columns[14].HeaderText = "Cliente";
            dgVendas.Columns[15].Visible = false;
            dgVendas.Columns[16].Visible = false;
            dgVendas.Columns[17].Visible = false;
            dgVendas.Columns[18].Visible = false;
            dgVendas.Columns[19].Visible = false;
            dgVendas.Columns[20].Visible = false;
            dgVendas.Columns[21].HeaderText = "Telefone Cliente";
            dgVendas.Columns[22].Visible = false;
            dgVendas.Columns[23].Visible = false;
            dgVendas.Columns[24].Visible = false;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormViewVenda form = new FormViewVenda(dgVendas);
            form.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgVendas.DataSource = controller.BuscarVenda(txtDigiteAqui.Text);
            dgVendas.DataMember = "venda";
        }
    }
}
