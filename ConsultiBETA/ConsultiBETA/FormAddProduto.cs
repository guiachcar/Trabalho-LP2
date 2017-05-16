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
        public FormAddProdutos(DataGridView dgProdutos)
        {
            Produto produto = Listas.produtos[dgProdutos.CurrentRow.Index];
            InitializeComponent();
            lbID.Text = produto.Id.ToString();
            txtNome.Text = produto.Nome;
            txtTipo.Text = produto.Tipo;
            txtDescricao.Text = produto.Descricao;
            txtValorCompra.Text = produto.Valor_compra.ToString();
            txtValor.Text = produto.Valor_venda.ToString();
        }

        private void btnSalver_Click(object sender, EventArgs e)
        {

            if(lbID.Text == "Produto ID")
            {
                             Produto produto = new Produto();

                produto.Id = Listas.produtos.Count + 1;
                produto.Nome = txtNome.Text;
                produto.Tipo = txtTipo.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Valor_compra = float.Parse(txtValorCompra.Text);
                produto.Valor_venda = float.Parse(txtValor.Text);

                produtos.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormProdutos p = Application.OpenForms["FormProdutos"] as FormProdutos;

                if (p != null)
                {
                    p.Exibir();
                }
            }
            else
            {
                int id = int.Parse(lbID.Text);
                Listas.produtos[id].Nome = txtNome.Text;
                Listas.produtos[id].Tipo = txtTipo.Text;
                Listas.produtos[id].Descricao = txtDescricao.Text;
                Listas.produtos[id].Valor_compra = float.Parse(txtValorCompra.Text);
                Listas.produtos[id].Valor_venda = float.Parse(txtValor.Text);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
