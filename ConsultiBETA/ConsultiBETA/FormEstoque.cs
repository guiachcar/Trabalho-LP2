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
            if (dgProdutos.RowCount == 0 || FormLogin.nivelAcesso == "Atendente" || FormLogin.nivelAcesso == "Tecnico")
            {
                btnEditar.Visible = false;
            }
            dgProdutos.Columns[0].Visible = false;
            dgProdutos.Columns[1].Visible = false;
            dgProdutos.Columns[3].Visible = false;
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
            //dgProdutos.DataSource = controller.BuscarProduto(txtDigiteAqui.Text);
            //dgProdutos.DataMember = "produto";
        }
    }
}
