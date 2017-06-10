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

        ChamadoController controllerChamado = new ChamadoController();
        public Principal()
        {
            

            InitializeComponent();


        }
        public Principal(FormLogin login, frm_splash frm_splash)
        {
            login_frm = login;
            splash_frm = frm_splash;
            InitializeComponent();
            lbUsuario.Text = FormLogin.usuarioLogadoNome;
            if(FormLogin.nivelAcesso != "Gerencia")
            {
                historicoToolStripMenuItem.Visible = false;
            }
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    relatóriosToolStripMenuItem.Visible = false;
                    historicoToolStripMenuItem.Visible = false;

                    
                    ExibirRecente();
                    break;
                case "Administrativo":
                    lbFinalizarChamados.Text = "Visualizar";
                    
                    break;
                case "Estoquista":
                    relatóriosToolStripMenuItem.Visible = false;
                    cadastroToolStripMenuItem.Visible = false;
                    lbAbrirChamado.Visible = false;
                    lbFinalizarChamados.Text = "Visualizar";
                    pbAbrirChamado.Visible = false;
                    vendaToolStripMenuItem.Visible = false;
                    ExibirRecente();
                    break;
                case "Gerencia":
                    lbFinalizarChamados.Text = "Visualizar/Fechar";
                    ExibirRecente();
                    break;
                case "Técnico":
                    cadastroToolStripMenuItem.Visible = false;
                    relatóriosToolStripMenuItem.Visible = false;
                    vendaToolStripMenuItem.Visible = false;
                    pbAbrirChamado.Visible = false;
                    lbAbrirChamado.Visible = false;
                    ExibirTecnico();
                    break;
            }
        }
        public void ExibirRecente()
        {
            dgChamadosRecentes.DataSource = controllerChamado.ListarChamadosRecentes();
            dgChamadosRecentes.DataMember = "chamado";
            dgChamadosRecentes.Columns[0].HeaderText = "Chamado";
            dgChamadosRecentes.Columns[1].Visible = false;
            dgChamadosRecentes.Columns[2].Visible = false;
            dgChamadosRecentes.Columns[3].Visible = false;
            dgChamadosRecentes.Columns[4].HeaderText = "Descrição";
            dgChamadosRecentes.Columns[5].Visible = false;
            dgChamadosRecentes.Columns[6].HeaderText = "Data Abertura";
            dgChamadosRecentes.Columns[7].HeaderText = "Data Agendamento";
            dgChamadosRecentes.Columns[8].HeaderText = "Data Fechamento";
            dgChamadosRecentes.Columns[9].Visible = false;
            dgChamadosRecentes.Columns[10].HeaderText = "Cliente";
            dgChamadosRecentes.Columns[11].Visible = false;
            dgChamadosRecentes.Columns[12].Visible = false;
            dgChamadosRecentes.Columns[13].Visible = false;
            dgChamadosRecentes.Columns[14].Visible = false;
            dgChamadosRecentes.Columns[15].Visible = false;
            dgChamadosRecentes.Columns[16].Visible = false;
            dgChamadosRecentes.Columns[17].HeaderText = "Telefone Cliente";
            dgChamadosRecentes.Columns[18].Visible = false;
            dgChamadosRecentes.Columns[19].Visible = false;
            dgChamadosRecentes.Columns[20].HeaderText = "Status";
        }
        public void ExibirTecnico()
        {
            dgChamadosRecentes.DataSource = controllerChamado.ListarChamadosTecnico(FormLogin.usuarioLogado);
            dgChamadosRecentes.DataMember = "chamado";
            dgChamadosRecentes.Columns[0].HeaderText = "Chamado";
            dgChamadosRecentes.Columns[1].Visible = false;
            dgChamadosRecentes.Columns[2].Visible = false;
            dgChamadosRecentes.Columns[3].Visible = false;
            dgChamadosRecentes.Columns[4].HeaderText = "Descrição";
            dgChamadosRecentes.Columns[5].Visible = false;
            dgChamadosRecentes.Columns[6].HeaderText = "Data Abertura";
            dgChamadosRecentes.Columns[7].HeaderText = "Data Agendamento";
            dgChamadosRecentes.Columns[8].HeaderText = "Data Fechamento";
            dgChamadosRecentes.Columns[9].Visible = false;
            dgChamadosRecentes.Columns[10].HeaderText = "Cliente";
            dgChamadosRecentes.Columns[11].Visible = false;
            dgChamadosRecentes.Columns[12].Visible = false;
            dgChamadosRecentes.Columns[13].Visible = false;
            dgChamadosRecentes.Columns[14].Visible = false;
            dgChamadosRecentes.Columns[15].Visible = false;
            dgChamadosRecentes.Columns[16].Visible = false;
            dgChamadosRecentes.Columns[17].HeaderText = "Telefone Cliente";
            dgChamadosRecentes.Columns[18].Visible = false;
            dgChamadosRecentes.Columns[19].Visible = false;
            dgChamadosRecentes.Columns[20].HeaderText = "Status";
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
            login_frm.ShowDialog(splash_frm);
            

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
            //FormRelatorio form = new FormRelatorio();
            //form.MdiParent = this;
            //form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados();
            form.ShowDialog();
            ExibirTecnico();
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios(FormLogin.usuarioLogado);
            form.ShowDialog();

        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorico form = new FormHistorico();
            form.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda form = new FormVenda();
            form.Show();
        }

        private void pbFinalizarChamado_Click(object sender, EventArgs e)
        {
            FormAddChamados form = new FormAddChamados(dgChamadosRecentes);
            form.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    ExibirRecente();
                    break;
                case "Administrativo":
                    ExibirRecente();

                    break;
                case "Estoquista":
                    ExibirRecente();
                    break;
                case "Gerencia":
                    ExibirRecente();
                    break;
                case "Técnico":
                    ExibirTecnico();
                    break;
            }
        }
    }
}
