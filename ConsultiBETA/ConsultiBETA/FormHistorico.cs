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
    public partial class FormHistorico : Form
    {
        HistoricoController controller = new HistoricoController();
        public FormHistorico()
        { 
            InitializeComponent();
            Exibir();
        }
        public void Exibir()
        {
            dgHistorico.DataSource = controller.Listar();
            dgHistorico.DataMember = "historico";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = dgHistorico.CurrentRow.Cells[2].Value.ToString();
            FormViewHistorico form = new FormViewHistorico(query);
            form.ShowDialog();
        }
    }
}
