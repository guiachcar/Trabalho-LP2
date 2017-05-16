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
    public partial class FormAddFuncionarios : Form
    {

        FuncionarioController funcionarios = new FuncionarioController();
        public FormAddFuncionarios()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            Funcionario funcionario = new Funcionario();

            funcionario.Cpf = txtCPF.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Endereco = txtRua.Text;
            funcionario.Nro = txtNro.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Uf = cbEstado.Text;
            funcionario.Cep = txtCEP.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Salario = float.Parse(txtSalario.Text);

            funcionarios.Cadastrar(funcionario);
            MessageBox.Show("Funcionario Cadastrado com sucesso", "Consulti", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            this.Close();
            FormFuncionarios f = Application.OpenForms["FormFuncionarios"] as FormFuncionarios;

            if (f != null)
            {
                f.Exibir();
            }

        }       
    }
}
