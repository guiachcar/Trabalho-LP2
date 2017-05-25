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
        ServicoController controller = new ServicoController();
        public FormServicos()
        {
            InitializeComponent();
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    btnEditar.Text = "Visualizar";
                    btnExcluir.Visible = false;
                    btnNovo.Visible = false;
                    break;

            }
            Exibir();
        }
        

        public void Exibir()
        {
            dgServicos.DataSource = controller.Listar();
            dgServicos.DataMember = "servico";
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
            controller.Excluir(controller.getServico(int.Parse(dgServicos.Rows[dgServicos.CurrentRow.Index].Cells[0].Value.ToString())));
            Exibir();
        }
    }
}
