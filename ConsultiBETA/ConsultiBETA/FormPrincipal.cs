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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            form.MdiParent = this;
            form.Show();


           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSobre form = new FormSobre();
            form.MdiParent = this;
            form.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicos form = new FormServicos();
            form.MdiParent = this;
            form.Show();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.MdiParent = this;
            form.Show();

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoque form = new FormEstoque();
            form.MdiParent = this;
            form.Show();
        }
    }
}
