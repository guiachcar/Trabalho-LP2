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
        public FormEstoque()
        {
            InitializeComponent();
        }

        public void Exibir()
        {
            dgProdutos.Rows.Clear();
            foreach (Produto p in Listas.produtos )
            {
                Estoque result = Listas.estoques.Find(x => x.Produto_id == p.Id);
                dgProdutos.Rows.Add(p.Nome, p.Tipo, p.Descricao, p.Valor_venda, p.Valor_compra,result.Quantidade);
            }
        }

        

        private void EntradaItem(object sender, EventArgs e)
        {

        }

        private void EditarClick(object sender, EventArgs e)
        {

        }
    }
}
