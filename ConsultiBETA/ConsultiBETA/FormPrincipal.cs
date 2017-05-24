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
    public partial class Principal : Form
    {
        FormLogin login_frm;
        frm_splash splash_frm;
        
        public Principal()
        {
            

            InitializeComponent();


        }
        public Principal(FormLogin login, frm_splash frm_splash)
        {
            login_frm = login;
            splash_frm = frm_splash;
            InitializeComponent();
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    relatóriosToolStripMenuItem.Visible = false;
                    lbFinalizarChamados.Visible = false;
                    pbFinalizarChamado.Visible = false;
                    break;
                case "Administrativo":
                    dgChamadosRecentes.Visible = false;
                    lbFinalizarChamados.Visible = false;
                    pbFinalizarChamado.Visible = false;
                    pbAbrirChamado.Visible = false;
                    lbAbrirChamado.Visible = false;

                    break;
                case "Estoquista":
                    relatóriosToolStripMenuItem.Visible = false;
                    cadastroToolStripMenuItem.Visible = false;
                    lbAbrirChamado.Visible = false;
                    lbFinalizarChamados.Visible = false;
                    pbAbrirChamado.Visible = false;
                    pbFinalizarChamado.Visible = false;
                    break;
                case "Gerencia":
                    pbFinalizarChamado.Visible = false;
                    lbFinalizarChamados.Visible = false;
                    break;
                case "Técnico":
                    cadastroToolStripMenuItem.Visible = false;
                    relatóriosToolStripMenuItem.Visible = false;
                    pbAbrirChamado.Visible = false;
                    lbAbrirChamado.Visible = false;
                    break;
            }
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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios();
            //form.MdiParent = this;
            form.ShowDialog();


           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormChamados form = new FormChamados();
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSobre form = new FormSobre();
            //form.MdiParent = this;
            form.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login_frm.Close();
            splash_frm.Close();          

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicos form = new FormServicos();
            //form.MdiParent = this;
            form.ShowDialog();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            //form.MdiParent = this;
            form.ShowDialog();

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoque form = new FormEstoque();
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
