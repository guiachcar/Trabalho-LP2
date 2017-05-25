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
        public FormAddServicos(DataGridView dgServicos)
        {
            InitializeComponent();
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtValor.ReadOnly = true;
                    btnSalver.Visible = false;
                    break;
                
            }
            Servico servico = servicos.getServico(int.Parse(dgServicos.Rows[dgServicos.CurrentRow.Index].Cells[0].Value.ToString()));
            
            lbID.Text = servico.Id.ToString();
            txtNome.Text = servico.Nome;
            txtDescricao.Text = servico.Descricao;
            txtValor.Text = servico.Valor.ToString();
        }
        private void btnSalver_Click(object sender, EventArgs e)
        {

            Servico servico = new Servico();

            if (lbID.Text == "Serviço ID")
            {
                servico.Nome = txtNome.Text;
                servico.Descricao = txtDescricao.Text;
                servico.Valor = float.Parse(txtValor.Text);

                servicos.Cadastrar(servico);
                MessageBox.Show("Serviço cadastrado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormServicos s = Application.OpenForms["FormServicos"] as FormServicos;

                if (s != null)
                {
                    s.Exibir();
                }
            }
            else
            {
                int id = int.Parse(lbID.Text) -1;
                servico.Nome = txtNome.Text;
                servico.Descricao = txtDescricao.Text;
                servico.Valor = float.Parse(txtValor.Text);
                servicos.Editar(servico);
                MessageBox.Show("Serviço alterado com sucesso!", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                FormServicos s = Application.OpenForms["FormServicos"] as FormServicos;

                if (s != null)
                {
                    s.Exibir();
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
