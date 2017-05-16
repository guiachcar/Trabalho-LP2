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
        public FormFuncionarios()
        {
            InitializeComponent();
            Exibir();
        }
        public void Exibir()
        {
            dgFuncioanarios.Rows.Clear();
            foreach (Funcionario f in Listas.funcionarios)
            {
                dgFuncioanarios.Rows.Add(f.Id,f.Nome, f.Cpf, f.Telefone, f.Endereco, f.Nro,f.Cep,f.Bairro,f.Cidade,f.Uf);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = new DataGridViewRow();
            linha = dgFuncioanarios.CurrentRow;
            FormAddFuncionarios form = new FormAddFuncionarios();
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioController funcionarios = new FuncionarioController();
            funcionarios.Excluir(funcionarios.getFunc(dgFuncioanarios.CurrentRow.Index));
            Exibir();
        }
    }
}
