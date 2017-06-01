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
    public partial class FormServicos : Form
    {
        
        ServicoController controller = new ServicoController();
        public FormServicos()
        {

            InitializeComponent();
            btnSelecionar.Visible = false;
            txtQuantidade.Visible = false;
            lbQuantidade.Visible = false;
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    btnEditar.Text = "Visualizar";
                    btnExcluir.Visible = false;
                    btnNovo.Visible = false;
                    break;

            }
            Exibir();
        }
        public FormServicos(DataGridView dgItemServico)
        {
            InitializeComponent();
            Exibir();
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnNovo.Visible = false;

            
        }
        

        public void Exibir()
        {
            dgServicos.DataSource = controller.Listar();
            dgServicos.DataMember = "servico";
            dgServicos.Columns[0].HeaderText = "Id";
            dgServicos.Columns[1].HeaderText = "Nome";
            dgServicos.Columns[2].HeaderText = "Descrição";
            dgServicos.Columns[3].HeaderText = "Valor";

        }
        


        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddServicos form = new FormAddServicos();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAddServicos form = new FormAddServicos(dgServicos);
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controller.Excluir(controller.getServico(int.Parse(dgServicos.Rows[dgServicos.CurrentRow.Index].Cells[0].Value.ToString())));
            Exibir();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgServicos.CurrentRow != null)
            {
                if(txtQuantidade.Text != "")
                {
                    FormAddChamados.dgvItemsServicos.Rows.Add(dgServicos.Rows[dgServicos.CurrentRow.Index].Cells[0].Value.ToString(), dgServicos.Rows[dgServicos.CurrentRow.Index].Cells[1].Value.ToString(), txtQuantidade.Text);
                    this.Close();
                }else
                {
                    MessageBox.Show("O campo Quantidade é obrigatório!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }
    }
}
