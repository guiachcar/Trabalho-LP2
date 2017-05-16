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
        public FormProdutos()
        {
            InitializeComponent();
            Exibir();
        }

        public void Exibir()
        {
            dgProdutos.Rows.Clear();
            foreach(Produto p in Listas.produtos)
            {
                dgProdutos.Rows.Add(p.Id, p.Nome, p.Tipo, p.Descricao, p.Valor_venda, p.Valor_compra);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAddProdutos form = new FormAddProdutos(dgProdutos);
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoController produtos = new ProdutoController();
            if(dgProdutos != null)
            {
                produtos.Excluir(produtos.getProduto(dgProdutos.CurrentRow.Index));
            }
            Exibir();
        }
    }
}
