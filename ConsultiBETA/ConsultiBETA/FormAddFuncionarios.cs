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
        int index = 1;
        FuncionarioController funcionarios = new FuncionarioController();
        public FormAddFuncionarios()
        {
            InitializeComponent();            
        }
        public FormAddFuncionarios(DataGridView form1)
        {
            Funcionario funcionario = Listas.funcionarios[form1.CurrentRow.Index];
            InitializeComponent();
            lbID.Text = funcionario.Id.ToString();
            txtCPF.SelectedText = funcionario.Cpf;
            txtNome.SelectedText = funcionario.Nome;
            txtRua.SelectedText = funcionario.Endereco;
            txtNro.SelectedText = funcionario.Nro;
            txtBairro.SelectedText = funcionario.Bairro;
            txtCidade.SelectedText = funcionario.Cidade;
            cbEstado.SelectedItem = funcionario.Uf;
            txtCEP.SelectedText = funcionario.Cep;
            cbCargo.SelectedItem = funcionario.Cargo;
            txtTelefone.SelectedText = funcionario.Telefone;
            txtSalario.SelectedText = funcionario.Salario.ToString();
            
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if(lbID.Text == "Funcionario ID")
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Id = Listas.funcionarios.Count + 1;
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
            else
            {
                int id = int.Parse(lbID.Text);
                Listas.funcionarios[id].Cpf = txtCPF.Text;
                Listas.funcionarios[id].Nome = txtNome.Text;
                Listas.funcionarios[id].Endereco = txtRua.Text;
                Listas.funcionarios[id].Nro = txtNro.Text;
                Listas.funcionarios[id].Bairro = txtBairro.Text;
                Listas.funcionarios[id].Cidade = txtCidade.Text;
                Listas.funcionarios[id].Uf = cbEstado.Text;
                Listas.funcionarios[id].Cep = txtCEP.Text;
                Listas.funcionarios[id].Cargo = cbCargo.Text;
                Listas.funcionarios[id].Telefone = txtTelefone.Text;
                Listas.funcionarios[id].Salario = float.Parse(txtSalario.Text);

                MessageBox.Show("Funcionario Alterado com sucesso", "Consulti", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
                FormFuncionarios f = Application.OpenForms["FormFuncionarios"] as FormFuncionarios;

                if (f != null)
                {
                    f.Exibir();
                }
            }
        }
                
    }
}
