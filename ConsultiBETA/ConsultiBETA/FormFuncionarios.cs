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
    public partial class FormFuncionarios : Form
    {
        FuncionarioController controller = new FuncionarioController();
        public FormFuncionarios()
        {
            InitializeComponent();
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    btnNovo.Visible = false;
                    btnExcluir.Visible = false;
                    btnEditar.Text = "Visualizar";
                    break;
                case "Administrativo":
                    btnExcluir.Visible = false;
                    break;

            }
            Exibir();
        }
        public void Exibir()
        {
            
            dgFuncioanarios.DataSource = controller.Listar();
            dgFuncioanarios.DataMember = "pessoa";
            dgFuncioanarios.Columns[0].Visible = false;
            dgFuncioanarios.Columns[1].HeaderText = "Nome";
            dgFuncioanarios.Columns[2].HeaderText = "Endereço";
            dgFuncioanarios.Columns[3].HeaderText = "Número";
            dgFuncioanarios.Columns[4].Visible = false;
            dgFuncioanarios.Columns[5].HeaderText = "Cidade";
            dgFuncioanarios.Columns[6].HeaderText = "Estado";
            dgFuncioanarios.Columns[7].Visible = false;
            dgFuncioanarios.Columns[8].HeaderText = "Telefone";
            dgFuncioanarios.Columns[9].Visible = false;
            dgFuncioanarios.Columns[10].Visible = false;
            dgFuncioanarios.Columns[11].Visible = false;
            dgFuncioanarios.Columns[12].HeaderText = "Cargo";
            dgFuncioanarios.Columns[13].Visible = false;
            dgFuncioanarios.Columns[14].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios(dgFuncioanarios);
            form.Show();
  
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente excluir o Funcionário?", "Excluir funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                controller.Excluir(controller.getFunc(int.Parse(dgFuncioanarios.Rows[dgFuncioanarios.CurrentRow.Index].Cells[0].Value.ToString())));
                Exibir();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgFuncioanarios.DataSource = controller.BuscarFuncionario(txtDigiteAqui.Text);
            dgFuncioanarios.DataMember = "pessoa";
        }
    }
}
