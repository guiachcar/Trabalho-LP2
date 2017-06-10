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
    public partial class FormEstoque : Form
    {
        EstoqueController controller = new EstoqueController();
        public FormEstoque()
        {
            InitializeComponent();
            Exibir();
            if (dgProdutos.RowCount == 0 || FormLogin.nivelAcesso == "Atendente" || FormLogin.nivelAcesso == "Técnico" || FormLogin.nivelAcesso == "Administrativo")
            {
                btnEditar.Visible = false;
                btnNovoProduto.Visible = false;
            }
            dgProdutos.Columns[0].Visible = false;
            dgProdutos.Columns[1].Visible = false;
            dgProdutos.Columns[2].HeaderText = "Quantidade";
            dgProdutos.Columns[3].Visible = false;
            dgProdutos.Columns[4].HeaderText = "Nome";
            dgProdutos.Columns[5].HeaderText = "Tipo";
            dgProdutos.Columns[6].HeaderText = "Descrição";
            dgProdutos.Columns[7].HeaderText ="Valor";
            dgProdutos.Columns[8].Visible = false;

        }
        
        public void Exibir()
        {
            dgProdutos.DataSource = controller.Listar();
            dgProdutos.DataMember = "estoque";
  
        }



        private void EntradaItem(object sender, EventArgs e)
        {
            FormAddEstoque form = new FormAddEstoque();
            form.Show();
        }

        private void EditarClick(object sender, EventArgs e)
        {
            FormAddEstoque form = new FormAddEstoque(dgProdutos);
            form.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgProdutos.DataSource = controller.BuscarEstoque(txtDigiteAqui.Text);
            dgProdutos.DataMember = "estoque";
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos();
            form.ShowDialog();
        }
    }
}
