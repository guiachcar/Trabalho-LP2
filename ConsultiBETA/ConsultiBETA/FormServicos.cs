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
        public FormServicos()
        {
            InitializeComponent();
            Exibir();
        }
        

        public void Exibir()
        {
            dgServicos.Rows.Clear();
            foreach (Servico s in Listas.servicos)
            {
                dgServicos.Rows.Add(s.Id, s.Nome, s.Descricao, s.Valor);
            }
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
            ServicoController produtos = new ServicoController();
            if(dgServicos != null)
            {
                produtos.Excluir(produtos.getServico(dgServicos.CurrentRow.Index));
            }
            Exibir();
        }
    }
}
