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
            /*dgFuncioanarios.Rows.Clear();
            foreach (Funcionario f in Listas.funcionarios)
            {
                dgFuncioanarios.Rows.Add(f.Id,f.Nome, f.Cpf, f.Telefone, f.Endereco, f.Nro,f.Cep,f.Bairro,f.Cidade,f.Uf);
            }
            */
            dgFuncioanarios.DataSource = controller.Listar();
            dgFuncioanarios.DataMember = "pessoa";
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
            controller.Excluir(controller.getFunc(int.Parse(dgFuncioanarios.Rows[dgFuncioanarios.CurrentRow.Index].Cells[0].Value.ToString())));
            Exibir();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txtDigiteAqui.Text;

            dgFuncioanarios.Rows.Clear();
            List<Funcionario> result = Listas.funcionarios.FindAll(x => x.Nome == busca );
            foreach (Funcionario f in result)
            {
                {
                    dgFuncioanarios.Rows.Add(f.Id, f.Nome, f.Cpf, f.Telefone, f.Endereco, f.Nro, f.Cep, f.Bairro, f.Cidade, f.Uf);
                }
            }
        }
    }
}
