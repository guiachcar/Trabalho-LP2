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
            InitializeComponent();
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    txtNome.ReadOnly = true;
                    txtTipo.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtValor.ReadOnly = true;
                    txtValorCompra.ReadOnly = true;
                    btnSalver.Visible = false;
                    break;

            }
            int id = int.Parse(dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            Produto produto = produtos.getProduto(id);

            lbID.Text = produto.Id.ToString();
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtTipo.Text = produto.Tipo;
            txtValor.Text = produto.Valor_venda.ToString();
            txtValorCompra.Text = produto.Valor_compra.ToString();
        }
        protected bool ValidarCampos()
        {
            decimal numero;
            if (txtNome.Text == string.Empty || txtTipo.Text == string.Empty || txtDescricao.Text == string.Empty)
            {

                MessageBox.Show("Favor preencher os campos corretamente!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                if (decimal.TryParse(txtValor.Text, out numero) || decimal.TryParse(txtValorCompra.Text, out numero))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("O campo Valor contem caracteres invalidos!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
        }
        private void btnSalver_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                string valor_compra = txtValorCompra.Text.Replace(".", "");
                string valor_venda = txtValor.Text.Replace(".", "");

                Produto produto = new Produto();

                if (lbID.Text == "Produto ID")
                {
                    produto.Nome = txtNome.Text;
                    produto.Tipo = txtTipo.Text;
                    produto.Descricao = txtDescricao.Text;
                    produto.Valor_venda = decimal.Parse(valor_venda);
                    produto.Valor_compra = decimal.Parse(valor_compra);

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
                    produto.Id = id;
                    produto.Nome = txtNome.Text;
                    produto.Tipo = txtTipo.Text;
                    produto.Descricao = txtDescricao.Text;
                    produto.Valor_venda = decimal.Parse(valor_venda);
                    produto.Valor_compra = decimal.Parse(valor_compra);
                    produtos.Editar(produto);
                    MessageBox.Show("Produto alterado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FormProdutos p = Application.OpenForms["FormProdutos"] as FormProdutos;

                    if (p != null)
                    {
                        p.Exibir();
                    }
                }
            }
         


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            FormAddFuncionarios.Moeda(ref txtValor);
        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            FormAddFuncionarios.Moeda(ref txtValorCompra);
        }
    }
}
