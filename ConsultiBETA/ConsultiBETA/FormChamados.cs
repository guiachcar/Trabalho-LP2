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
    public partial class FormChamados : Form
    {
        public FormChamados()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados();
            form.Show();
        }

        private void btnFercharChamdo_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados();
            form.Show();
        }
    
    }
}
