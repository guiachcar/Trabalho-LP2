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
    public partial class FormProdutos : Form
    {
        ProdutoController controller = new ProdutoController();
        int verifica = 1;
        public FormProdutos()
        {
            InitializeComponent();
            btnSelecionar.Visible = false;
            txtQuantidade.Visible = false;
            lbQuantidade.Visible = false;
            Exibir();
        }
        public FormProdutos(int produto_id)
        {
            InitializeComponent();
            Exibir();
            btnExcluir.Visible = false;
            btnNovo.Visible = false;
            btnSelecionar.Visible = false;
            txtQuantidade.Visible = false;
            lbQuantidade.Visible = false;
            btnEditar.Text = "Selecionar";
            verifica = produto_id;
        }
        public FormProdutos(DataGridView dgItemProduto)
        {
            InitializeComponent();
            Exibir();
            btnExcluir.Visible = false;
            btnNovo.Visible = false;
            btnEditar.Visible = false;
        }

        public void Exibir()
        {
            dgProdutos.DataSource = controller.Listar();
            dgProdutos.DataMember = "produto";
            dgProdutos.Columns[0].HeaderText = "Id";
            dgProdutos.Columns[1].HeaderText = "Produto";
            dgProdutos.Columns[2].HeaderText = "Tipo";
            dgProdutos.Columns[3].HeaderText = "Descrição";
            dgProdutos.Columns[4].HeaderText = "Valor";
            dgProdutos.Columns[5].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(verifica != 0)
            {
                FormAddProdutos form = new FormAddProdutos(dgProdutos);
                form.Show();
            }
            else
            {
                FormAddEstoque.produto_id_selecionado = dgProdutos.CurrentRow.Index;
                this.Close();
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controller.Excluir(controller.getProduto(int.Parse(dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].Value.ToString())));
            Exibir();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgProdutos.DataSource = controller.BuscarProduto(txtDigiteAqui.Text);
            dgProdutos.DataMember = "produto";
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgProdutos.CurrentRow != null)
            {
                if (txtQuantidade.Text != "")
                {
                    FormAddChamados.dgvItemsProdutos.Rows.Add(dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].Value.ToString(), dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[1].Value.ToString(), txtQuantidade.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("O campo Quantidade é obrigatório!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

        }
    }
}
