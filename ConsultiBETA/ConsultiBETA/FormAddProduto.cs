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
    public partial class FormAddProdutos : Form
    {
        ProdutoController produtos = new ProdutoController();
        public FormAddProdutos()
        {
            InitializeComponent();
        }

        private void btnSalver_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Tipo = txtTipo.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Valor_compra = float.Parse(txtValorCompra.Text);
            produto.Valor_venda = float.Parse(txtValor.Text);
            produto.Quantidade = int.Parse(txtQuantidade.Text);

            produtos.Cadastrar(produto);
            MessageBox.Show("Produto cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            FormProdutos p = Application.OpenForms["FormProdutos"] as FormProdutos;

            if(p != null)
            {
                p.Exibir();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
