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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos();
            form.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddEstoque form = new FormAddEstoque();
            form.Show();
        }
    }
}
