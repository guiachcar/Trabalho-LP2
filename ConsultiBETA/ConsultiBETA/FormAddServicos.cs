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
    public partial class FormAddServicos : Form
    {

        ServicoController servicos = new ServicoController();
        public FormAddServicos()
        {
            InitializeComponent();
        }

        private void btnSalver_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            servico.Nome = txtNome.Text;
            servico.Descricao = txtDescricao.Text;
            servico.Valor = float.Parse(txtValor.Text);

            servicos.Cadastrar(servico);
            MessageBox.Show("Serviço cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            FormServicos s = Application.OpenForms["FormServicos"] as FormServicos;

            if(s != null)
            {
                s.Exibir();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
