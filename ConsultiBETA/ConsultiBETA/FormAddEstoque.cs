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
    public partial class FormAddEstoque : Form
    {
        EstoqueController controller = new EstoqueController();
        ProdutoController controllerProduto = new ProdutoController();
        
        public static int produto_id_selecionado; 
        public FormAddEstoque()
        {
            InitializeComponent();
        }

        public FormAddEstoque(DataGridView dgProdutos)
        {
            InitializeComponent();
            Estoque estoque = controller.getEstoque(int.Parse(dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].Value.ToString()));
            btnProduto.Visible = false;
            lbId.Text = estoque.Id.ToString();
            lbProdutoNome.Text = estoque.Nome;
            lbIDProduto.Text = estoque.Id.ToString();
            txtQuantidade.Text = estoque.Quantidade.ToString();
        }
        private void btnSalver_Click(object sender, EventArgs e)
        {
            decimal numero;
            if (decimal.TryParse(txtQuantidade.Text, out numero))
            {

                Estoque estoque = new Estoque();
                estoque.Id = int.Parse(lbId.Text);
                estoque.Quantidade = int.Parse(txtQuantidade.Text);
                controller.Editar(estoque);
                MessageBox.Show("Quantidade alterada com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormEstoque es = Application.OpenForms["FormEstoque"] as FormEstoque;

                if (es != null)
                {
                    es.Exibir();
                }
            }
            else
            {
                MessageBox.Show("O Quantidade contem caracteres invalidos!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos(0);
            form.ShowDialog();
            btnProduto.Visible = false;
        }
    }
}
